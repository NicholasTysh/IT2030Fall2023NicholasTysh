using System;
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
    }
}
