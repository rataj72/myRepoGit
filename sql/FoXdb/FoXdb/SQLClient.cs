using System;
using System.Collections.Generic;
using System.Data;

namespace FoXdb
{
    public abstract class SQLClient : IClient
    {
        private string UserId;
        private string Password;
        private string Host;
        private string Port;
        private string Database;

        protected SQLClient(string userId, string password, string host, string port, string database)
        {
            UserId = userId;
            Password = password;
            Host = host;
            Port = port;
            Database = database;
        }

        public abstract Dictionary<int, List<string>> Select(string columnName, string nameOfTable);

        public abstract void Insert(string columnName, string nameOfTable, string value);

        public abstract void Update(string nameOfTable, string updateColumnName, string updateValue,string selectorColumnName, string selectorValue);

        public abstract void Delete(string columnName, string nameOfTable, string deleteValue);

    }
}