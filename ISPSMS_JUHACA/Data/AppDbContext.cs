using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSMS_JUHACA.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public static AppDbContext instance;
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            instance = this;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-AEJ6B24K\\SQLEXPRESS;Initial Catalog=connected_subscribers_db;User ID=ISPSMS_JUHACA;Password=OPTICALITSOLUTIONS2025;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");    
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Domain.Models.ConnectedSubscribers> ConnectedSubscribers { get; set; }
    }
}
