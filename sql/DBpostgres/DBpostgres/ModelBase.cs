namespace DBpostgres
{
    public abstract class ModelBase
    {
        protected PostgreClient PostgreClient = new PostgreClient("postgres","start12345","localhost","testowa");

        protected string TableName;

        protected ModelBase(string tabName)
        {
            TableName = tabName;
        }
    }
}