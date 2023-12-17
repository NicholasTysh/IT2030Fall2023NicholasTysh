﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NickPixPlus.Models;

namespace NickPixPlus.Data
{
    public class NickPixPlusContext : DbContext
    {
        public NickPixPlusContext (DbContextOptions<NickPixPlusContext> options)
            : base(options)
        {
        }

        public DbSet<NickPixPlus.Models.Movie> Movie { get; set; } = default!;

        //public DbSet<NickPixPlus.Models.ContactModel>? ContactModel { get; set; }
        public DbSet<NickPixPlus.Models.ContactModel>? ContactDb { get; set; }

        //public DbSet<NickPixPlus.Models.ProductModel>? ProductModel { get; set; }
        public DbSet<NickPixPlus.Models.ProductModel>? ProductDb { get; set; }
    }
}
