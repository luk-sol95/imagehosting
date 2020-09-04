using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ImageHosting.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Azure.Storage.Blobs;
using System.IO;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;

namespace ImageHosting.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if(User.Identity.IsAuthenticated)
            {

                var albumList = _context.Albums.Where(s => s.owner_id == User.FindFirst("emails").Value);
                var permissionSet = _context.Permissions.Where(s => s.user_id == User.FindFirst("emails").Value).ToArray();
                var externalAlbumList = new List<ExternalAlbum>();
     
                foreach (var perm in permissionSet)
                {
                    var tempAlbum = _context.Albums.Where(s => s.id == perm.album_id).First();
                    ExternalAlbum newAlbum = new ExternalAlbum
                    {
                        id = tempAlbum.id,
                        owner_id = tempAlbum.owner_id,
                        name = tempAlbum.name,
                        permission_level = perm.permission_level
                    };
                    externalAlbumList.Add(newAlbum);
                }
                return View("Index", new IndexModel {personalAlbums = albumList, externalAlbums = externalAlbumList});
            } else
            {
                return View("Index");
            }
        }
        private readonly MyDatabaseContext _context;
        private readonly BlobServiceClient blobClient;
        public HomeController(MyDatabaseContext context)
        {
            _context = context;
            blobClient = new BlobServiceClient("BlobEndpoint=https://tisoltysinskistorage.blob.core.windows.net/;QueueEndpoint=https://tisoltysinskistorage.queue.core.windows.net/;FileEndpoint=https://tisoltysinskistorage.file.core.windows.net/;TableEndpoint=https://tisoltysinskistorage.table.core.windows.net/;SharedAccessSignature=sv=2019-12-12&ss=bfqt&srt=sco&sp=rwdlacupx&se=2024-08-31T02:50:56Z&st=2020-08-30T18:50:56Z&spr=https,http&sig=IR8aijqoK7CjPJEwScx4FAauqZmu4NxF0HkYP3EaiRQ%3D");
        }
        [Authorize]
        public IActionResult Claims()
        {
            return View();
        }
        public IActionResult AlbumView(int albumItemId)
        {

            return View("AlbumView", getAlbumViewModel(albumItemId));
        }

        private AlbumView getAlbumViewModel(int albumId)
        {
            var queriedAlbumItem = _context.Albums.Where(a => a.id == albumId).First();
            var photoList = _context.Photos.Where(s => s.album_id == queriedAlbumItem.id);
            var albumViewModel = new AlbumView();
            albumViewModel.id = queriedAlbumItem.id;
            albumViewModel.photoList = photoList;
            albumViewModel.name = queriedAlbumItem.name;
            albumViewModel.owner_id = queriedAlbumItem.owner_id;
            if(queriedAlbumItem.owner_id == User.FindFirst("emails").Value)
            {
                albumViewModel.permission_level = 2;
            } else
            {
                albumViewModel.permission_level = _context.Permissions.Where(s => s.album_id == albumId && s.user_id == User.FindFirst("emails").Value).First().permission_level;
            }
            return albumViewModel;
        }
        private string changeEmailToContainerName(string email)
        {
            return email.Replace("@", "-").Replace(".", "-").Replace("+", "-");
        }
        [HttpPost]
        public IActionResult UploadFilesToBlobStorage(string name, int albumid)
        {
            var files = HttpContext.Request.Form.Files;
            var containerClient = getContainerForUser();
            
            uploadImagesFromForm(containerClient, files, albumid);

           return AlbumView(albumid);

        }
        private BlobContainerClient getContainerForUser()
        {
            var containerName = changeEmailToContainerName(User.FindFirst("emails").Value);
            var containerClient = blobClient.GetBlobContainerClient(containerName);
            containerClient.CreateIfNotExists(PublicAccessType.Blob);
            return containerClient;
        }
        private void uploadImagesFromForm(BlobContainerClient containerClient, IFormFileCollection files, int albumid)
        {
            foreach (var file in files)
            {
                Azure.Response<BlobContentInfo> blobResponse;

                if (file.FileName.EndsWith(".jpg") || file.FileName.EndsWith(".png") || file.FileName.EndsWith(".bmp") || file.FileName.EndsWith(".jpeg"))
                {
                    var blobClient = containerClient.GetBlobClient(file.FileName);
                    blobResponse = blobClient.Upload(file.OpenReadStream(), true);
                    _context.Photos.Add(new Photo
                    {
                        name = file.FileName,
                        album_id = albumid,
                        blob_address = blobClient.Uri.ToString().Split('?')[0]
                    });
                }


            }
            _context.SaveChanges();
        }
        [HttpPost]
        public IActionResult AddPermissions (int albumid, int access, string email)
        {
            if (!(_context.Albums.Where(s => s.id == albumid).First().owner_id == email))
            {
                var existingPermission = _context.Permissions.Where(s => (s.album_id == albumid) && (s.user_id == email));
                if(existingPermission.Any())
                {
                    _context.Remove(existingPermission.First());
                    _context.SaveChanges();
                }
                _context.Permissions.Add(new Permission
                {
                    album_id = albumid,
                    permission_level = access,
                    user_id = email
                });
                _context.SaveChanges();
            }
            return AlbumView(albumid);

        }
        public IActionResult CreateAlbum()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAlbum(string albumname)
        {
            Album newAlbum = new Album
            {
                name = albumname,
                owner_id = User.FindFirst("emails").Value
            };
            _context.Albums.Add(newAlbum);
            _context.SaveChanges();
            var filesFromForm = HttpContext.Request.Form.Files;

            if(filesFromForm.Any())
            {
                uploadImagesFromForm(getContainerForUser(), filesFromForm, newAlbum.id);
            }
            return Index();
        }

        public IActionResult DeleteImage(int albumid, int photoid)
        {
            deletePhoto(photoid);
            return AlbumView(albumid);
        }

        public IActionResult RemoveAlbum(int albumid)
        {

            return View("RemoveAlbum", getAlbumViewModel(albumid));
        }


        private void deletePhoto(int photoId)
        {
            var containerClient = getContainerForUser();
            var photoRecord = _context.Photos.Where(s => s.id == photoId).First();
            var blobClient = containerClient.GetBlobClient(photoRecord.name);
            blobClient.DeleteIfExists();
            _context.Photos.Remove(photoRecord);
            _context.SaveChanges();
        }
        public IActionResult ConfirmDelete(int albumid)
        {
            var albumViewModel = getAlbumViewModel(albumid);
            foreach (var item in albumViewModel.photoList.ToArray())
            {
                deletePhoto(item.id);
            }
            var albumRecord = _context.Albums.Where(s => s.id == albumViewModel.id).First();
            var albumPermissions = _context.Permissions.Where(s => s.album_id == albumid).ToArray();
            foreach (var perm in albumPermissions)
            {
                _context.Remove(perm);
            }
            _context.SaveChanges();
            _context.Remove(albumRecord);
            _context.SaveChanges();
            return Index();
        }

        public IActionResult DontDelete(int albumid)
        {
            return AlbumView(albumid);
        }
    }
}