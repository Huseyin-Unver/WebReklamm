using ApplicationCore_WebReklam.Entities.Concrete;
using ApplicationCore_WebReklam.Entities.UserEntities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_WebReklam.Context
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<City> Cities { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Designer> Designers { get; set; }
        public DbSet<Village> Villages { get; set; }
        public DbSet<Sektor> Sectors { get; set; }
    }
}
