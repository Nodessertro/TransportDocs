namespace TransportDocs.Models
{
    public class AllDocumentsRequest
    {
        public DateTime Date { get; set; }
        public string City { get; set; }

        public int CustomerId { get; set; }
        public int CarrierId { get; set; }

        public decimal Cost { get; set; }

        // Акт
        public bool ActWithoutNumber { get; set; }

        // Получатель
        public bool IsPhysicalPerson { get; set; }
        public int? ContractorId { get; set; }
        public string Whom { get; set; }
        public string Address { get; set; }
    }
}
