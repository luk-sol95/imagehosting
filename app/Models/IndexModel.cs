using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;

namespace ImageHosting.Models
{
    public class IndexModel
    {
        public IQueryable<Album> personalAlbums { get; set; }
        public IEnumerable<ExternalAlbum> externalAlbums { get; set; }
    }
}
