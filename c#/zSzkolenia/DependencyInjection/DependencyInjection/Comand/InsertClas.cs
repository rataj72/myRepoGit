using DependencyInjection.interfaces;

namespace DependencyInjection.dbNames.Comand
{
    public class InsertClas : IInsert
    {
        public string Insert(string text)
        {
            return "insetr";
        }
    }
}