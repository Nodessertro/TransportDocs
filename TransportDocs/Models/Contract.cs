namespace TransportDocs.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }

        public int CustomerId { get; set; }
        public int CarrierId { get; set; }

        // Для отображения в гриде
        public string CustomerName { get; set; }
        public string CarrierName { get; set; }
    }
}
