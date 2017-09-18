using DependencyInjection.interfaces;

namespace DependencyInjection.dbNames.Comand
{
    public class UpdateClas : IUpdate
    {
        public string Update(string text)
        {
            return "update";
        }
    }
}