namespace fabryka
{
    public class PostCode
    {
        public PostCode(int _prefix, int _sufix)
        {
            prefix = _prefix;
            sufix = _sufix;
        }

        private int prefix;
        private int sufix;


        public int Prefix()
        {
            return prefix;
        }

        public int Sufix()
        {
            return sufix;
        }
    }
}