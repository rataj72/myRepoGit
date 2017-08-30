namespace DBpostgres
{
    public class ModelTransfer : ModelBase
    {
        public int insert(SQLClientBase record)
        {
            string query = "insert into " + TableName + "(name) values ("+ record.UserName + ");";

            return PostgreClient.SetData(query);
        }

        public ModelTransfer() : base("testowa")
        {
        }
    }
}