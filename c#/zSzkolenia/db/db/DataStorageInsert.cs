namespace PeterWinformsApp
{
    public class DataStorageInsert : DataStorageQuery
    {
        private const string ComandName = "insert";

        private const string ComandPattern = "{0} into {1} ({2}) values ({3});";

        public string values = "'ivon','770'";

        public override string GetSetDataComand(StorageDataModel<object> model)
        {
            return string.Format(ComandPattern, ComandName, model.TableName, GetColumnsDelimitedList(model), values);
        }
    }
}