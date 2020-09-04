using System;
using System.ComponentModel.DataAnnotations;

namespace ImageHosting.Models
{
    public class Photo
    {
        public int id { get; set; }
        public string name { get; set; }
        public int album_id { get; set; }
        public string blob_address { get; set; }
    }
}
