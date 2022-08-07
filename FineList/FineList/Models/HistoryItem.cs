using FineList.Components;

namespace FineList.Models
{
    public class HistoryItem
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string? Description { get; set; }
        public HistoryItemType HistoryItemType { get; set; }
        public double Amount { get; set; }
        public Player Player { get; set; }
        public Player? Admin { get; set; }


    }
}
