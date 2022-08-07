namespace FineList.Models
{
    public class Fine
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string? Description { get; private set; }
        public double? Amount { get; private set; }

        public Fine(int id, string name, string description, double amount)
        {
            Id = id;
            Name = name;
            Description = description;
            Amount = amount;
        }
    }
}
