using DependencyInjection.dbNames.Comand;
using DependencyInjection.interfaces;

namespace DependencyInjection.dbNames
{
    public class Postgres : IdbName
    {
        private string _insert;
        private string _update;

        public Postgres(string insert, string update)
        {
            _insert = insert;
            _update = update;
        }

        public string pgMethod(string text)
        {
            return "metoda" + text;
        }
    }
}