using System;
using System.ComponentModel.DataAnnotations;

namespace ImageHosting.Models
{
    public class Album
    {
        public int id { get; set; }
        public string name { get; set; }
        public string owner_id { get; set; }
    }
}
