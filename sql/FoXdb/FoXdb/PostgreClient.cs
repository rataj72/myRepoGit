using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using Npgsql;

namespace FoXdb
{
    public class PostgreClient : SQLClient
    {
        protected NpgsqlConnection connection;
        public string connectionString;

        public PostgreClient(string userId, string password, string host, string port, string database) : base(userId, password, host, port, database)
        {
            connectionString = $"User ID={userId};Password={password};Host={host};Port={port};Database={database};";
        }

        public override Dictionary<int,List<string>> Select(string nameOfTable, string columnName)
        {
            using (connection = new NpgsqlConnection(connectionString))
            {
                string userComand = $"select {columnName} from {nameOfTable} ";
                NpgsqlCommand npgCommand = new NpgsqlCommand(userComand, connection);
                npgCommand.Connection.Open();   

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(npgCommand);
                var res = new DataSet();
                adapter.Fill(res);

                XDocument doc = XDocument.Parse(res.GetXml());
                
                XMLParser parser = new XMLParser();

                var columns = columnName != "*" ? columnName.Split(',') :new []{"*"} ;

                foreach (string t in columns)
                {
                    parser.columns.Add(t);
                }
                return parser.ParseToDictionaryList(doc);
            }
        }

        public override void Insert(string nameOfTable, string columnName, string insertValue)
        {
            insertValue = insertValue.Replace(",", "','");
            insertValue = "'" + insertValue + "'";

            var query = String.Format("insert into {0}({1}) values ({2});", nameOfTable, columnName, insertValue);

            using (connection = new NpgsqlConnection(connectionString))
            {
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                var liczba = command.ExecuteNonQuery();
            }
        }

        public override void Update(string nameOfTable, string updateColumnName, string updateValue, string selectorColumnName, string selectorValue)
        {
            var a = "UPDATE Customers SET ContactName = 'Alfred Schmidt', City = 'Frankfurt' WHERE CustomerID = 1; ";

            var query = String.Format("UPDATE {0} SET {1} = '{2}' WHERE {3} = '{4}';", nameOfTable, updateColumnName, updateValue, selectorColumnName , selectorValue);

            using (connection = new NpgsqlConnection(connectionString))
            {
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                var liczba = command.ExecuteNonQuery();
            }
        }

        public override void Delete(string nameOfTable, string columnName, string deleteValue)
        {
            deleteValue = columnName != "id" ?  "'" + deleteValue + "'" : deleteValue;

            var query = String.Format("DELETE FROM {0} WHERE {1} = {2};", nameOfTable, columnName, deleteValue);

            using (connection = new NpgsqlConnection(connectionString))
            {
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                var liczba = command.ExecuteNonQuery();
            }
        }
    }
}