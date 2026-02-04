using TransportDocs.Data;
using TransportDocs.Models;

namespace TransportDocs.Repositories
{
    public class TransportationBillRepository
    {
        public List<TransportationBill> GetAll()
        {
            var list = new List<TransportationBill>();

            using var con = Db.GetConnection();
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = @"
                SELECT
                    tb.Id,
                    tb.Date,
                    tb.CustomerId,
                    tb.CarrierId,
                    tb.ContractorId,
                    tb.InvoiceNumber,
                    tb.RequestNumber,
                    tb.Responsible,
                    tb.SupportingDocuments,
                    tb.Cost,
                    tb.Address,
                    tb.Whom,
                    cu.Name AS CustomerName,
                    ca.Name AS CarrierName,
                    co.Name AS ContractorName
                FROM TransportationBills tb
                JOIN Customers cu ON cu.Id = tb.CustomerId
                JOIN Carriers ca ON ca.Id = tb.CarrierId
                JOIN Contractors co ON co.Id = tb.ContractorId
                ORDER BY tb.Date DESC
            ";

            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                list.Add(new TransportationBill
                {
                    Id = r.GetInt32(0),
                    Date = DateTime.Parse(r.GetString(1)),
                    CustomerId = r.GetInt32(2),
                    CarrierId = r.GetInt32(3),
                    ContractorId = r.GetInt32(4),
                    InvoiceNumber = r.GetString(5),
                    RequestNumber = r.GetString(6),
                    Responsible = r.GetString(7),
                    SupportingDocuments = r.GetString(8),
                    Cost = r.GetDecimal(9),
                    Address = r.GetString(10),
                    Whom = r.GetString(11),
                    CustomerName = r.GetString(12),
                    CarrierName = r.GetString(13),
                    ContractorName = r.GetString(14)
                });
            }

            return list;
        }

        public void Add(TransportationBill b)
        {
            using var con = Db.GetConnection();
            con.Open();

            var cmd = con.CreateCommand();
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

            cmd.Parameters.AddWithValue("@date", b.Date.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@cust", b.CustomerId);
            cmd.Parameters.AddWithValue("@car", b.CarrierId);
            cmd.Parameters.AddWithValue("@contr", b.ContractorId);
            cmd.Parameters.AddWithValue("@inv", b.InvoiceNumber);
            cmd.Parameters.AddWithValue("@req", b.RequestNumber);
            cmd.Parameters.AddWithValue("@resp", b.Responsible);
            cmd.Parameters.AddWithValue("@docs", b.SupportingDocuments);
            cmd.Parameters.AddWithValue("@cost", b.Cost);
            cmd.Parameters.AddWithValue("@addr", b.Address);
            cmd.Parameters.AddWithValue("@whom", b.Whom);

            cmd.ExecuteNonQuery();
        }

        public void Update(TransportationBill b)
        {
            using var con = Db.GetConnection();
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = @"
                UPDATE TransportationBills SET
                    Date = @date,
                    CustomerId = @cust,
                    CarrierId = @car,
                    ContractorId = @contr,
                    InvoiceNumber = @inv,
                    RequestNumber = @req,
                    Responsible = @resp,
                    SupportingDocuments = @docs,
                    Cost = @cost,
                    Address = @addr,
                    Whom = @whom
                WHERE Id = @id
            ";

            cmd.Parameters.AddWithValue("@id", b.Id);
            cmd.Parameters.AddWithValue("@date", b.Date.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@cust", b.CustomerId);
            cmd.Parameters.AddWithValue("@car", b.CarrierId);
            cmd.Parameters.AddWithValue("@contr", b.ContractorId);
            cmd.Parameters.AddWithValue("@inv", b.InvoiceNumber);
            cmd.Parameters.AddWithValue("@req", b.RequestNumber);
            cmd.Parameters.AddWithValue("@resp", b.Responsible);
            cmd.Parameters.AddWithValue("@docs", b.SupportingDocuments);
            cmd.Parameters.AddWithValue("@cost", b.Cost);
            cmd.Parameters.AddWithValue("@addr", b.Address);
            cmd.Parameters.AddWithValue("@whom", b.Whom);

            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var con = Db.GetConnection();
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM TransportationBills WHERE Id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }
    }
}
