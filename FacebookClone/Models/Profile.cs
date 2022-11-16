namespace FacebookClone.Models
{
    public class Profile
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public  DateTimeOffset BrithDate { get; set; }
    }
}
