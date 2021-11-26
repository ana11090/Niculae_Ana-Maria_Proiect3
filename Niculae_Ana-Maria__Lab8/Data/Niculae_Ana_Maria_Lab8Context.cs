using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Niculae_Ana_Maria_Lab8.Models;

namespace Niculae_Ana_Maria_Lab8.Data
{
    public class Niculae_Ana_Maria_Lab8Context : DbContext
    {
        public Niculae_Ana_Maria_Lab8Context (DbContextOptions<Niculae_Ana_Maria_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Niculae_Ana_Maria_Lab8.Models.Book> Book { get; set; }

        public DbSet<Niculae_Ana_Maria_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Niculae_Ana_Maria_Lab8.Models.Category> Category { get; set; }
    }
}
