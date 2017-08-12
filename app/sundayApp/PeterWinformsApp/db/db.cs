using System.Data;
using Npgsql;

namespace PeterWinformsApp
{
    public class db
    {
        public DataSet getData(string sql)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("User ID=postgres;Password=start12345;Host=localhost;Port=5432;Database=hydra"))
            {
                connection.Open();

                NpgsqlCommand command = new NpgsqlCommand(sql,connection);

                //var dataReader = command.ExecuteReader();
                //dataReader.

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                DataSet result = new DataSet();
                adapter.Fill(result);
                return result;
            }
            
            
        }
    }
}