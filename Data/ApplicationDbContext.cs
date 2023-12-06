using GymBooking.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace GymBooking.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<GymClass> Gymclasses{ get; set; }
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<ApplicationUserGymClass>  ApplicationUserGymsJoin { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
    }
}
