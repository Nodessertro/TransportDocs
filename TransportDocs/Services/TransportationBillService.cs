using TransportDocs.Data;
using TransportDocs.Models;

namespace TransportDocs.Services
{
    public class TransportationBillService
    {
        private const int PHYSICAL_PERSON_CONTRACTOR_ID = 1;

        public string CreateWithNumbering(
            AllDocumentsRequest req,
            string invoiceNumber
        )
        {
            using var con = Db.GetConnection();
            con.Open();

            using var tx = con.BeginTransaction();
            var numbering = new NumberingService(con, tx);

            string requestNumber = numbering.GetNextTripNumber(
                req.CarrierId,
                req.Date
            );

            var cmd = con.CreateCommand();
            cmd.Transaction = tx;
            cmd.CommandText = @"
                INSERT INTO TransportationBills
                (
                    Date, CustomerId, CarrierId, ContractorId,
                    InvoiceNumber, RequestNumber,
                    Responsible, SupportingDocuments,
                    Cost, Address, Whom
                )
                VALUES
                (
                    @date, @cust, @car, @contr,
                    @inv, @req,
                    @resp, @docs,
                    @cost, @addr, @whom
                )
            ";

            cmd.Parameters.AddWithValue(
                "@date",
                req.Date.ToString("yyyy-MM-dd")
            );
            cmd.Parameters.AddWithValue("@cust", req.CustomerId);
            cmd.Parameters.AddWithValue("@car", req.CarrierId);
            cmd.Parameters.AddWithValue(
                "@contr",
                req.IsPhysicalPerson
                    ? PHYSICAL_PERSON_CONTRACTOR_ID
                    : req.ContractorId
            );
            cmd.Parameters.AddWithValue("@inv", invoiceNumber);
            cmd.Parameters.AddWithValue("@req", requestNumber);
            cmd.Parameters.AddWithValue("@resp", string.Empty);
            cmd.Parameters.AddWithValue("@docs", string.Empty);
            cmd.Parameters.AddWithValue("@cost", req.Cost);
            cmd.Parameters.AddWithValue("@addr", req.Address);
            cmd.Parameters.AddWithValue("@whom", req.Whom);

            cmd.ExecuteNonQuery();
            tx.Commit();

            return requestNumber;
        }
    }
}
