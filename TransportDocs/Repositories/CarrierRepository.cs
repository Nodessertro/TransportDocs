using TransportDocs.Models;
using TransportDocs.Data;

namespace TransportDocs.Repositories
{
    public class CarrierRepository
    {
        public Carrier GetById(int id)
        {
            using var connection = Db.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Carriers WHERE Id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();
            if (!reader.Read())
            {
                return new Carrier();
            }

            return new Carrier
            {
                Id = reader.GetInt32(0),
                Name = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                Ogrn = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                Inn = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                Address = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                CarNumber = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                CarModel = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                Phone = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                Tonnage = reader.IsDBNull(8) ? string.Empty : reader.GetString(8)
            };
        }

        public List<Carrier> GetAll()
        {
            var list = new List<Carrier>();

            using var connection = Db.GetConnection();
            connection.Open();
            
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM Carriers";
            
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Carrier
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Ogrn = reader.GetString(2),
                    Inn = reader.GetString(3),
                    Address = reader.GetString(4),
                    CarNumber = reader.GetString(5),
                    CarModel = reader.GetString(6),
                    Phone = reader.GetString(7),
                    Tonnage = reader.GetString(8)
                });
            }
            return list;
        }

        public void Add(Carrier c)
        {
            using var connection = Db.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO Carriers
                (Name, Ogrn, Inn, Address, CarNumber, CarModel, Phone, Tonnage)
                VALUES (@name, @ogrn, @inn, @address, @carnumber, @carmodel, @phone, @tonnage)
            ";

            cmd.Parameters.AddWithValue("@name", c.Name);
            cmd.Parameters.AddWithValue("@ogrn", c.Ogrn);
            cmd.Parameters.AddWithValue("@inn", c.Inn);
            cmd.Parameters.AddWithValue("@address", c.Address);
            cmd.Parameters.AddWithValue("@carnumber", c.CarNumber);
            cmd.Parameters.AddWithValue("@carmodel", c.CarModel);
            cmd.Parameters.AddWithValue("@phone", c.Phone);
            cmd.Parameters.AddWithValue("@tonnage", c.Tonnage);

            cmd.ExecuteNonQuery();
        }

        public void Update(Carrier c)
        {
            using var connection = Db.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                UPDATE Carriers SET
                    Name = @name,
                    Ogrn = @ogrn,
                    Inn = @inn,
                    Address = @address,
                    CarNumber = @carnumber,
                    CarModel = @carmodel,
                    Phone = @phone,
                    Tonnage = @tonnage
                WHERE Id = @id
            ";

            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@name", c.Name);
            cmd.Parameters.AddWithValue("@ogrn", c.Ogrn);
            cmd.Parameters.AddWithValue("@inn", c.Inn);
            cmd.Parameters.AddWithValue("@address", c.Address);
            cmd.Parameters.AddWithValue("@carnumber", c.CarNumber);
            cmd.Parameters.AddWithValue("@carmodel", c.CarModel);
            cmd.Parameters.AddWithValue("@phone", c.Phone);
            cmd.Parameters.AddWithValue("@tonnage", c.Tonnage);

            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var connection = Db.GetConnection();
            connection.Open();

            var cmd = connection.CreateCommand();
            cmd.CommandText = "DELETE FROM Carriers WHERE Id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }
    }
}
