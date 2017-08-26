using System.Security.Cryptography.X509Certificates;

namespace fabryka
{
    public class PostCodeValidator
    {
        public bool IsCodeValid(Province province, string code)
        {
            int prefix = int.Parse(code.Substring(0,2));
            int sufix = int.Parse(code.Substring(3,3));

            return true;
        }
    }
}