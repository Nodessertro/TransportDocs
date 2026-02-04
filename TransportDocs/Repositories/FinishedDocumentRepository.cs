using System.Text;
using TransportDocs.Data;
using TransportDocs.Models;

namespace TransportDocs.Repositories
{
    public class FinishedDocumentRepository
    {
        public void Add(FinishedDocument doc)
        {
            using var con = Db.GetConnection();
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO FinishedDocuments
                (CustomerId, CarrierId, Date, Cost, City, ActNumber, TripNumber)
                VALUES
                (@cust, @car, @date, @cost, @city, @act, @trip)
            ";

            cmd.Parameters.AddWithValue("@cust", doc.CustomerId);
            cmd.Parameters.AddWithValue("@car", doc.CarrierId);
            cmd.Parameters.AddWithValue("@date", doc.Date);
            cmd.Parameters.AddWithValue("@cost", doc.Cost);
            cmd.Parameters.AddWithValue("@city", doc.City);
            cmd.Parameters.AddWithValue("@act", doc.ActNumber);
            cmd.Parameters.AddWithValue("@trip", doc.TripNumber);

            cmd.ExecuteNonQuery();
        }

        public List<FinishedDocument> GetAll()
        {
            var list = new List<FinishedDocument>();

            using var con = Db.GetConnection();
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM FinishedDocuments ORDER BY Date DESC";

            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                list.Add(new FinishedDocument
                {
                    Id = r.GetInt32(0),
                    CustomerId = r.GetInt32(1),
                    CarrierId = r.GetInt32(2),
                    Date = DateTime.Parse(r.GetString(3)),
                    Cost = r.GetDecimal(4),
                    City = r.GetString(5),
                    ActNumber = r.GetString(6),
                    TripNumber = r.GetString(7),
                });
            }

            return list;
        }
    }
}
