using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LAB2_gaftone_delia.Models;

namespace LAB2_gaftone_delia.Data
{
    public class LAB2_gaftone_deliaContext : DbContext
    {
        public LAB2_gaftone_deliaContext (DbContextOptions<LAB2_gaftone_deliaContext> options)
            : base(options)
        {
        }

        public DbSet<LAB2_gaftone_delia.Models.Book> Book { get; set; } = default!;

        public DbSet<LAB2_gaftone_delia.Models.Publisher>? Publisher { get; set; }

        public DbSet<LAB2_gaftone_delia.Models.Author>? Author { get; set; }
    }
}
