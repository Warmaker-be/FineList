namespace FineList.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAdmin { get; set; }


        public Player(int id, string firstName, string lastName, bool isAdmin)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            IsAdmin = isAdmin;
        }
    }
}
