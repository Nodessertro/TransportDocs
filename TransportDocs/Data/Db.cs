using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportDocs.Data
{
    public static class Db
    {
        public static SqliteConnection GetConnection()
        {
            var dbPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Data",
                "data.db"
            );
            return new SqliteConnection($"Data Source={dbPath}");
        }
    }
}
