using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace NickflixPlus.Data
{
    public class NickflixPlusContext : DbContext
    {
        public NickflixPlusContext(DbContextOptions<NickflixPlusContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
