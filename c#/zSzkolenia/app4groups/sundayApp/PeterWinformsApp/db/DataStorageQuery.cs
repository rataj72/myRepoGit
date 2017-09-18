using System.Linq;

namespace PeterWinformsApp
{
    public abstract class DataStorageQuery
    {
        private const string ComandColumnsDelimiter = ", ";

        public abstract string GetSetDataComand(StorageDataModel<object> model);

        protected virtual string GetColumnsDelimitedList(StorageDataModel<object> model)
        {
            return string.Join(ComandColumnsDelimiter, model.Data.Select(item => item.Key).ToArray());
        }


    }
}