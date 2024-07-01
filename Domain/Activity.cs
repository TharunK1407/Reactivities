//Entity = Model
namespace Domain
{
    public class Activity
    {
        public Activity() { } // Parameterless constructor
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Category {get; set;}
        public string City { get; set;}
        public string Venue { get; set; }
    }
}