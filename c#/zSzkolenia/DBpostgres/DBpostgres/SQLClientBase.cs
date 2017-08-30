using System.Data;

namespace DBpostgres
{
    public abstract class SQLClientBase : IdbClient
    {
        public string UserName;
        protected string Passwod;
        protected string DBAdres;
        private string DbName;

        protected SQLClientBase(string name, string passwod, string adAdres, string dbName)
        {
            UserName = name;
            DBAdres = adAdres;
            DbName = dbName;
            Passwod = passwod;
        }

        public abstract DataSet GetData(string query);


        public abstract int SetData(string query);

    }
}