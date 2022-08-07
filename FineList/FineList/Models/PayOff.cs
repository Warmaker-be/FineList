namespace FineList.Models
{
    public class PayOff
    {
        public int Id { get; private set; }
        public DateTime Timestamp { get; private set; }
        public Player Player { get; private set; }
        public Player Admin { get; private set; }
        public double Amount { get; private set; }


        public PayOff(int id, Player player, Player admin, double amount)
        {
            Id = id;
            Timestamp = DateTime.Now;
            Player = player;
            Admin = admin;
            Amount = amount;
        }
    }
}
