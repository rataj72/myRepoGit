using System.Collections.Generic;

namespace PeterWinformsApp
{
    public class ApplicationTestModel : StorageDataModel<object>
    {
        public ApplicationTestModel()
        {
            TableName = "ApplicationTest";
            Data = new Dictionary<string, object>
            {
                {"player", "peter"},
                {"points", "12354679"}
            };
        }
    }
}