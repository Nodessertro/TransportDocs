using TransportDocs.Models;
using TransportDocs.Data;

namespace TransportDocs.Repositories
{
    public class CarrierRepository
    {
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