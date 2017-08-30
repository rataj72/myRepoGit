using System.Data;

namespace DBpostgres
{
    public interface IdbClient
    {
        DataSet GetData(string query);

        int SetData(string query);

    }
}