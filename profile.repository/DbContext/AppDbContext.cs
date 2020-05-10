using Microsoft.EntityFrameworkCore;
using profile.data;
using System;
using System.Collections.Generic;
using System.Text;

namespace profile.repository
{
    public class AppDbContext: DbContext
    {
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<City> Cities { get; set; }
        public AppDbContext(): base() { }
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }
    }
}
