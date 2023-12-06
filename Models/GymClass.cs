using System.Collections.ObjectModel;

namespace GymBooking.Models
{
    public class GymClass
    {
      

        // pk
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public DateTime  StartTime { get; set; }
        public TimeSpan Duration  { get; set; }
        public DateTime EndTime { get { return StartTime + Duration; } }
        public string Description { get; set; }     //Fk

        //// navigation
        //public ApplicationUser ApplicationUser { get; set; } = new ApplicationUser();
        ////many to many
        public ICollection<ApplicationUser> AttendingMembers { get; set; }=new Collection<ApplicationUser>();
     

    }
}
