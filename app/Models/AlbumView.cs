using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.Graph;
using System.Collections.Generic;
using System.Linq;

namespace ImageHosting.Models
{
    public class AlbumView
    {
        public int id { get; set; }
        public string name { get; set; }
        public string owner_id { get; set; }

        public int permission_level { get; set; }
        public IQueryable<Photo> photoList { get; set; }
    }
}
