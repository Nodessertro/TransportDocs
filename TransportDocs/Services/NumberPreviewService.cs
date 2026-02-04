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
                  AND Type = @type
                  AND Date IS NULL
            ";
            cmd.Parameters.AddWithValue("@car", carrierId);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@type", "ACT");

            var result = cmd.ExecuteScalar();

            int nextNumber = result == null
                ? 1
                : Convert.ToInt32(result) + 1;

            return nextNumber.ToString();
        }

        public string PreviewTripNumber(int carrierId, DateTime date)
        {
            string dateKey = date.ToString("yyyy-MM-dd");

            using var con = Db.GetConnection();
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = @"
                SELECT LastNumber
                FROM DocumentCounters
                WHERE CarrierId = @car
                  AND Date = @date
                  AND Type = @type
            ";
            cmd.Parameters.AddWithValue("@car", carrierId);
            cmd.Parameters.AddWithValue("@date", dateKey);
            cmd.Parameters.AddWithValue("@type", "TRIP");

            var result = cmd.ExecuteScalar();

            int nextNumber = result == null
                ? 1
                : Convert.ToInt32(result) + 1;

            string datePart = date.ToString("dd/MM/yy");

            return $"{datePart}-{nextNumber:00}";
        }
    }
}
