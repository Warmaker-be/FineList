namespace FineList.APIContracts
{
    public class FineIssuedRequest
    {
        public int Id { get; private set; }
        public int PlayerId { get; set; }
        public int AdminId { get; set; }
    }
}
