using GymBooking.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace GymBooking.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser,IdentityRole,string>//10 what id:string
    {
       
        //public DbSet<ApplicationUser> Users { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<GymClass> Gymclasses { get; set; }
        public DbSet<ApplicationUserGymClass> ApplicationUserGymsJoin { get; set; }

        //8
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUserGymClass>()
                .HasKey(k => new { k.GymClassId, k.ApplicationUserId });
        }
    }
}
