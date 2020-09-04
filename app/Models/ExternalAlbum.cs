using System;
using System.ComponentModel.DataAnnotations;

namespace ImageHosting.Models
{
    public class ExternalAlbum : Album
    {
        public int permission_level { get; set; }

    }
}
