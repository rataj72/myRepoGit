namespace fabryka.Provinces
{
    public class SilesianValidator : IProviceValidator
    {
        public bool IsCodeValid(PostCode code)
        {
            return code.Prefix() >= 47 && code.Prefix() <= 53;
        }
    }
}