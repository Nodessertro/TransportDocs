using TransportDocs.Data;

namespace TransportDocs.Services
{
    public class NumberPreviewService
    {
        
        public string PreviewActNumber(int carrierId)
        {
            int year = DateTime.Now.Year;

            using var con = Db.GetConnection();
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = @"
                SELECT LastNumber
                FROM DocumentCounters
                WHERE CarrierId = @car
                  AND Year = @year
            ";
            cmd.Parameters.AddWithValue("@car", carrierId);
            cmd.Parameters.AddWithValue("@year", year);

            var result = cmd.ExecuteScalar();

            int nextNumber = result == null
                ? 1
                : Convert.ToInt32(result) + 1;

            return nextNumber.ToString();
        }

        public string PreviewTripNumber(int carrierId, DateTime date)
        {
            int year = date.Year;

            using var con = Db.GetConnection();
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = @"
                SELECT LastNumber
                FROM DocumentCounters
                WHERE CarrierId = @car
                  AND Year = @year
            ";
            cmd.Parameters.AddWithValue("@car", carrierId);
            cmd.Parameters.AddWithValue("@year", year);

            var result = cmd.ExecuteScalar();

            int nextNumber = result == null
                ? 1
                : Convert.ToInt32(result) + 1;

            string datePart = date.ToString("dd/MM/yy");

            return $"{datePart}-{nextNumber}";
        }
    }
}
