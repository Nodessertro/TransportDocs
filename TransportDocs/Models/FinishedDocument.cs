namespace TransportDocs.Models
{
    public class FinishedDocument
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public int CarrierId { get; set; }

        public DateTime Date { get; set; }

        public decimal Cost { get; set; }
        public string City { get; set; }

        public string ActNumber { get; set; }
        public string TripNumber { get; set; }
    }
}
