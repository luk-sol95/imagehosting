using System;
using System.ComponentModel.DataAnnotations;

namespace ImageHosting.Models
{
    public class Permission
    {
        public int id { get; set; }
        public int permission_level { get; set; }
        public string user_id { get; set; }
        public int album_id { get; set; }

    }
}
