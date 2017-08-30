using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DBpostgres
{
    public class PostgreClient : SQLClientBase
    {
        protected NpgsqlConnection connection;
        private const string connectionPattern = "User ID=postgres;Password=start12345;Host=localhost;Port=5432;Database=testowa";
        private string connectionString;

        public PostgreClient(string name, string passwod, string adAdres, string dbName) : base(name, passwod, adAdres, dbName)
        {
            connectionString = connectionPattern; //string.Format(connectionPattern, dbName, adAdres, name, passwod);
        }

        public override DataSet GetData(string query)
        {
            using (connection = new NpgsqlConnection(connectionString))
            {
                NpgsqlCommand command = new NpgsqlCommand(query,connection);

                NpgsqlDataAdapter adapter= new NpgsqlDataAdapter(command);

                var res = new DataSet();
                    adapter.Fill(res);

                return res;
            }
        }

        public override int SetData(string query)
        {
            using (connection = new NpgsqlConnection(connectionString))
            {
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                return command.ExecuteNonQuery();
            }
        }
    }
}
