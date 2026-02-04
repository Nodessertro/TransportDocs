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
            int next = GetAndIncrementAct(carrierId, year);
            return next.ToString();
        }

        // -----------------------------
        // Заявка + накладная
        // -----------------------------
        public string GetNextTripNumber(int carrierId, DateTime date)
        {
            int next = GetAndIncrementTrip(carrierId, date);

            string datePart = date.ToString("dd/MM/yy");
            return $"{datePart}-{next:00}";
        }

        // -----------------------------
        // PREVIEW (без увеличения)
        // -----------------------------
        public string PreviewSimpleNumber(int carrierId, int year)
        {
            int next = GetCurrentAct(carrierId, year) + 1;
            return next.ToString();
        }

        public string PreviewTripNumber(int carrierId, DateTime date)
        {
            int next = GetCurrentTrip(carrierId, date) + 1;
            return $"{date:dd/MM/yy}-{next:00}";
        }

        // -----------------------------
        // ВНУТРЕННЯЯ ЛОГИКА
        // -----------------------------
        private int GetAndIncrementAct(int carrierId, int year)
        {
            int current = GetCurrentAct(carrierId, year);

            if (current == 0)
            {
                InsertCounterAct(carrierId, year);
                current = 0;
            }

            int next = current + 1;
            UpdateCounterAct(carrierId, year, next);

            return next;
        }

        private int GetAndIncrementTrip(int carrierId, DateTime date)
        {
            int current = GetCurrentTrip(carrierId, date);

            if (current == 0)
            {
                InsertCounterTrip(carrierId, date);
                current = 0;
            }

            int next = current + 1;
            UpdateCounterTrip(carrierId, date, next);

            return next;
        }

        private int GetCurrentAct(int carrierId, int year)
        {
            using var cmd = _connection.CreateCommand();
            cmd.Transaction = _transaction;
            cmd.CommandText = @"
                SELECT LastNumber
                FROM DocumentCounters
                WHERE CarrierId = @carrier
                  AND Year = @year
                  AND Type = @type
                  AND Date IS NULL
            ";

            cmd.Parameters.AddWithValue("@carrier", carrierId);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@type", "ACT");

            var result = cmd.ExecuteScalar();
            return result == null ? 0 : Convert.ToInt32(result);
        }

        private int GetCurrentTrip(int carrierId, DateTime date)
        {
            string dateKey = date.ToString("yyyy-MM-dd");

            using var cmd = _connection.CreateCommand();
            cmd.Transaction = _transaction;
            cmd.CommandText = @"
                SELECT LastNumber
                FROM DocumentCounters
                WHERE CarrierId = @carrier
                  AND Date = @date
                  AND Type = @type
            ";

            cmd.Parameters.AddWithValue("@carrier", carrierId);
            cmd.Parameters.AddWithValue("@date", dateKey);
            cmd.Parameters.AddWithValue("@type", "TRIP");

            var result = cmd.ExecuteScalar();
            return result == null ? 0 : Convert.ToInt32(result);
        }

        private void InsertCounterAct(int carrierId, int year)
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
            cmd.Parameters.AddWithValue("@type", "ACT");

            cmd.ExecuteNonQuery();
        }

        private void InsertCounterTrip(int carrierId, DateTime date)
        {
            string dateKey = date.ToString("yyyy-MM-dd");

            using var cmd = _connection.CreateCommand();
            cmd.Transaction = _transaction;
            cmd.CommandText = @"
                INSERT INTO DocumentCounters
                (CarrierId, Year, Date, Type, LastNumber)
                VALUES
                (@carrier, @year, @date, @type, 0)
            ";

            cmd.Parameters.AddWithValue("@carrier", carrierId);
            cmd.Parameters.AddWithValue("@year", date.Year);
            cmd.Parameters.AddWithValue("@date", dateKey);
            cmd.Parameters.AddWithValue("@type", "TRIP");

            cmd.ExecuteNonQuery();
        }

        private void UpdateCounterAct(int carrierId, int year, int lastNumber)
        {
            using var cmd = _connection.CreateCommand();
            cmd.Transaction = _transaction;
            cmd.CommandText = @"
                UPDATE DocumentCounters
                SET LastNumber = @last
                WHERE CarrierId = @carrier
                  AND Year = @year
                  AND Type = @type
                  AND Date IS NULL
            ";

            cmd.Parameters.AddWithValue("@last", lastNumber);
            cmd.Parameters.AddWithValue("@carrier", carrierId);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@type", "ACT");

            cmd.ExecuteNonQuery();
        }

        private void UpdateCounterTrip(int carrierId, DateTime date, int lastNumber)
        {
            string dateKey = date.ToString("yyyy-MM-dd");

            using var cmd = _connection.CreateCommand();
            cmd.Transaction = _transaction;
            cmd.CommandText = @"
                UPDATE DocumentCounters
                SET LastNumber = @last
                WHERE CarrierId = @carrier
                  AND Date = @date
                  AND Type = @type
            ";

            cmd.Parameters.AddWithValue("@last", lastNumber);
            cmd.Parameters.AddWithValue("@carrier", carrierId);
            cmd.Parameters.AddWithValue("@date", dateKey);
            cmd.Parameters.AddWithValue("@type", "TRIP");

            cmd.ExecuteNonQuery();
        }
    }
}
