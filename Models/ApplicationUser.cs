using Microsoft.AspNetCore.Identity;
using System.Collections.ObjectModel;

namespace GymBooking.Models
{
    public class ApplicationUser: IdentityUser
    {
        // Pk
        //public string  Id { get; set; }= default!;

        //// Navigation
        //public GymClass GymClass { get; set; } = default!;

        // many to many

        public Collection<ApplicationUserGymClass> AttendedClass  { get; set; }= new Collection<ApplicationUserGymClass>();
    }
}
