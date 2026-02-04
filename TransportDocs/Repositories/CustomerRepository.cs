using TransportDocs.Models;
using TransportDocs.Data;

namespace TransportDocs.Repositories
{
    public class CustomerRepository
    {
        public List<Customer> GetAll()
        {
            var list = new List<Customer>();

            using var connection = Db.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Customers";
            
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Customer
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Inn = reader.GetString(2),
                    Kpp = reader.GetString(3),
                    Ogrn = reader.GetString(4),
                    Address = reader.GetString(5),
                    DirectorName = reader.GetString(6)
                });
            }

            return list;
        }

        public void Add(Customer c)
        {
            using var connection = Db.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO Customers
                (Name, Inn, Kpp, Ogrn, Address, DirectorName)
                VALUES (@name, @inn, @kpp, @ogrn, @address, @director)
            ";

            cmd.Parameters.AddWithValue("@name", c.Name);
            cmd.Parameters.AddWithValue("@inn", c.Inn);
            cmd.Parameters.AddWithValue("@kpp", c.Kpp);
            cmd.Parameters.AddWithValue("@ogrn", c.Ogrn);
            cmd.Parameters.AddWithValue("@address", c.Address);
            cmd.Parameters.AddWithValue("@director", c.DirectorName);

            cmd.ExecuteNonQuery();
        }

        public void Update(Customer c)
        {
            using var connection = Db.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                UPDATE Customers SET
                    Name = @name,
                    Inn = @inn,
                    Kpp = @kpp,
                    Ogrn = @ogrn,
                    Address = @address,
                    DirectorName = @director
                WHERE Id = @id
            ";

            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@name", c.Name);
            cmd.Parameters.AddWithValue("@inn", c.Inn);
            cmd.Parameters.AddWithValue("@kpp", c.Kpp);
            cmd.Parameters.AddWithValue("@ogrn", c.Ogrn);
            cmd.Parameters.AddWithValue("@address", c.Address);
            cmd.Parameters.AddWithValue("@director", c.DirectorName);

            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = Db.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Customers WHERE Id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }
    }
}
