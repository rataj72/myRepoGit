namespace fabryka
{
    public class PostCodeExtractor : IPostCodeExtractor
    {
        public PostCode GetPostCode(string code)
        {
            int prefix = int.Parse(code.Substring(0, 2));
            int sufix = int.Parse(code.Substring(3, 3));

            return new PostCode(prefix,sufix);
        }
    }
}