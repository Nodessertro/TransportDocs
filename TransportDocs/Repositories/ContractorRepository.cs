using TransportDocs.Models;
using TransportDocs.Data;

namespace TransportDocs.Repositories
{
    public class ContractorRepository
    { 
        public List<Contractor> GetAll()
        {
            var list = new List<Contractor>();

            using var connection = Db.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Contractors";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Contractor
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Inn = reader.GetString(2),
                    Type = reader.GetString(3),
                    Address = reader.GetString(4),
                });
            }
            return list;
        }

        public void Add(Contractor c)
        {
            using var connection = Db.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO Contractors
                (Name, Inn, Type, Address)
                VALUES (@name, @inn, @type, @address)
            ";

            cmd.Parameters.AddWithValue("@name", c.Name);
            cmd.Parameters.AddWithValue("@inn", c.Inn);
            cmd.Parameters.AddWithValue("@type", c.Type);
            cmd.Parameters.AddWithValue("@address", c.Address);

            cmd.ExecuteNonQuery();
        }

        public void Update(Contractor c)
        {
            using var connection = Db.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                UPDATE Contractors SET
                    Name = @name,
                    Inn = @inn,
                    Type = @type,
                    Address = @address
                WHERE Id = @id
            ";

            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@name", c.Name);
            cmd.Parameters.AddWithValue("@inn", c.Inn);
            cmd.Parameters.AddWithValue("@type", c.Type);
            cmd.Parameters.AddWithValue("@address", c.Address);

            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = Db.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Contractors WHERE Id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }
    }
}