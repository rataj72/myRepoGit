namespace fabryka.Provinces
{
    public class MazowianValidator : IProviceValidator
    {
        public bool IsCodeValid(PostCode code)
        {
            return code.Prefix() >= 0 && code.Prefix() <= 5;
        }
    }
}