namespace fabryka
{
    public class RightBase : IPostCodeValidator
    {
        public virtual bool IsCodeValid(Province province, string code)
        {
            return true;
        }
    }
}