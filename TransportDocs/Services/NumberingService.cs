using Microsoft.Data.Sqlite;

namespace TransportDocs.Services
{
    public class NumberingService
    {
        private readonly SqliteConnection _connection;
        private readonly SqliteTransaction _transaction;

        public NumberingService(
            SqliteConnection connection,
            SqliteTransaction transaction
        )
        {
            _connection = connection;
            _transaction = transaction;
        }

        // -----------------------------
        // Акт (простой номер)
        // -----------------------------
        public string GetNextSimpleNumber(int carrierId, int year)
        {
            int next = GetAndIncrement(carrierId, year, "ACT");
            return next.ToString();
        }

        // -----------------------------
        // Заявка + накладная
        // -----------------------------
        public string GetNextTripNumber(int carrierId, DateTime date)
        {
            int year = date.Year;
            int next = GetAndIncrement(carrierId, year, "TRIP");

            string datePart = date.ToString("dd/MM/yy");
            return $"{datePart}-{next}";
        }

        // -----------------------------
        // PREVIEW (без увеличения)
        // -----------------------------
        public string PreviewSimpleNumber(int carrierId, int year)
        {
            int next = GetCurrent(carrierId, year, "ACT") + 1;
            return next.ToString();
        }

        public string PreviewTripNumber(int carrierId, DateTime date)
        {
            int next = GetCurrent(carrierId, date.Year, "TRIP") + 1;
            return $"{date:dd/MM/yy}-{next}";
        }

        // -----------------------------
        // ВНУТРЕННЯЯ ЛОГИКА
        // -----------------------------
        private int GetAndIncrement(int carrierId, int year, string type)
        {
            int current = GetCurrent(carrierId, year, type);

            if (current == 0)
            {
                InsertCounter(carrierId, year, type);
                current = 0;
            }

            int next = current + 1;
            UpdateCounter(carrierId, year, type, next);

            return next;
        }

        private int GetCurrent(int carrierId, int year, string type)
        {
            using var cmd = _connection.CreateCommand();
            cmd.Transaction = _transaction;
            cmd.CommandText = @"
                SELECT LastNumber
                FROM DocumentCounters
                WHERE CarrierId = @carrier
                  AND Year = @year
                  AND Type = @type
            ";

            cmd.Parameters.AddWithValue("@carrier", carrierId);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@type", type);

            var result = cmd.ExecuteScalar();
            return result == null ? 0 : Convert.ToInt32(result);
        }

        private void InsertCounter(int carrierId, int year, string type)
        {
            using var cmd = _connection.CreateCommand();
            cmd.Transaction = _transaction;
            cmd.CommandText = @"
                INSERT INTO DocumentCounters
                (CarrierId, Year, Type, LastNumber)
                VALUES
                (@carrier, @year, @type, 0)
            ";

            cmd.Parameters.AddWithValue("@carrier", carrierId);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@type", type);

            cmd.ExecuteNonQuery();
        }

        private void UpdateCounter(
            int carrierId,
            int year,
            string type,
            int lastNumber
        )
        {
            using var cmd = _connection.CreateCommand();
            cmd.Transaction = _transaction;
            cmd.CommandText = @"
                UPDATE DocumentCounters
                SET LastNumber = @last
                WHERE CarrierId = @carrier
                  AND Year = @year
                  AND Type = @type
            ";

            cmd.Parameters.AddWithValue("@last", lastNumber);
            cmd.Parameters.AddWithValue("@carrier", carrierId);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@type", type);

            cmd.ExecuteNonQuery();
        }
    }
}
