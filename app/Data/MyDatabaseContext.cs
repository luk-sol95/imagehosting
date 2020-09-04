using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ImageHosting.Models
{
    public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext(DbContextOptions<MyDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<ImageHosting.Models.Album> Albums{ get; set; }
        public DbSet<ImageHosting.Models.Photo> Photos { get; set; }
        public DbSet<ImageHosting.Models.Permission> Permissions { get; set; }

    }
}