namespace TransportDocs.Models
{
    public class TransportationBill
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int CustomerId { get; set; }
        public int CarrierId { get; set; }
        public int ContractorId { get; set; }

        public string InvoiceNumber { get; set; }   // номер накладной
        public string RequestNumber { get; set; }   // номер заявки

        public string Responsible { get; set; }
        public string SupportingDocuments { get; set; }

        public decimal Cost { get; set; }

        public string Address { get; set; }
        public string Whom { get; set; }

        // для грида
        public string CustomerName { get; set; }
        public string CarrierName { get; set; }
        public string ContractorName { get; set; }
    }
}
