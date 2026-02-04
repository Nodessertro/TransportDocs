using TransportDocs.Data;
using TransportDocs.Models;

namespace TransportDocs.Repositories
{
    public class ContractRepository
    {
        public List<Contract> GetAll()
        {
            var list = new List<Contract>();

            using var con = Db.GetConnection();
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = @"
                SELECT
                    c.Id,
                    c.Number,
                    c.Date,
                    c.CustomerId,
                    c.CarrierId,
                    cu.Name AS CustomerName,
                    ca.Name AS CarrierName
                FROM Contracts c
                JOIN Customers cu ON cu.Id = c.CustomerId
                JOIN Carriers ca ON ca.Id = c.CarrierId
                ORDER BY c.Date DESC
            ";

            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                list.Add(new Contract
                {
                    Id = r.GetInt32(0),
                    Number = r.GetString(1),
                    Date = DateTime.Parse(r.GetString(2)),
                    CustomerId = r.GetInt32(3),
                    CarrierId = r.GetInt32(4),
                    CustomerName = r.GetString(5),
                    CarrierName = r.GetString(6)
                });
            }

            return list;
        }

        public void Add(Contract c)
        {
            using var con = Db.GetConnection();
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO Contracts
                (Number, Date, CustomerId, CarrierId)
                VALUES (@num, @date, @cust, @car)
            ";

            cmd.Parameters.AddWithValue("@num", c.Number);
            cmd.Parameters.AddWithValue("@date", c.Date.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@cust", c.CustomerId);
            cmd.Parameters.AddWithValue("@car", c.CarrierId);

            cmd.ExecuteNonQuery();
        }

        public void Update(Contract c)
        {
            using var con = Db.GetConnection();
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = @"
                UPDATE Contracts SET
                    Number = @num,
                    Date = @date,
                    CustomerId = @cust,
                    CarrierId = @car
                WHERE Id = @id
            ";

            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@num", c.Number);
            cmd.Parameters.AddWithValue("@date", c.Date.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@cust", c.CustomerId);
            cmd.Parameters.AddWithValue("@car", c.CarrierId);

            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var con = Db.GetConnection();
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM Contracts WHERE Id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }
    }
}
