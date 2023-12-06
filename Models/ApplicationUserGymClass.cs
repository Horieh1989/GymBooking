namespace GymBooking.Models
{
    public class ApplicationUserGymClass
    {
        //Pk
        public Guid Id { get; set; }
        //Fk
        public Guid GymClassId { get; set; }
        public string ApplicationUserId { get; set; } = default!;

        // Navigation
        public GymClass GymClass  { get; set; } = default!;
        public ApplicationUser ApplicationUser { get; set; } = default!;
        //Joining 
        public DateTime DateJoined  { get; set; }

    }
}
