namespace fabryka
{
    public interface IPostCodeValidator
    {
        bool IsCodeValid(Province province, string code);
    }
}