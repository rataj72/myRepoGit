using System.Collections.Generic;
using System.Data;

namespace FoXdb
{
    public interface IClient
    {
        Dictionary<int, List<string>> Select(string columnName, string nameOfTable);

        void Insert(string columnName, string nameOfTable, string value);

        void Update(string nameOfTable, string updateColumnName, string updateValue, string selectorColumnName,string selectorValue);

        void Delete(string columnName, string nameOfTable, string deleteValue);
    }
}