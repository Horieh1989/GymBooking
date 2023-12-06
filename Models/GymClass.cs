using System.Collections.ObjectModel;

namespace GymBooking.Models
{
    public class GymClass
    {
        // pk
        public Guid Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public DateTime  StartTime { get; set; }
        public TimeSpan Duration  { get; set; }
        public DateTime EndTime  { get; set; }
        public string Description { get; set; }= string.Empty;
        //Fk

        // navigation
        public ApplicationUser ApplicationUser { get; set; } = new ApplicationUser();
        //many to many
        public Collection<ApplicationUser> Users { get; set; }=new Collection<ApplicationUser>();
     

    }
}
