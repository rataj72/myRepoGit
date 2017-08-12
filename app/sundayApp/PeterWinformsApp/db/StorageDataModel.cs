using System.Collections.Generic;

namespace PeterWinformsApp
{
    public abstract class StorageDataModel<T>
    {
        public string TableName { get; set; }
        public Dictionary<string, T> Data { get; set; }
    }
}