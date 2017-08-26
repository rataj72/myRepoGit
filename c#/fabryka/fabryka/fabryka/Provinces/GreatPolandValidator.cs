namespace fabryka.Provinces
{ 
    public class GreatPolandValidator : IProviceValidator
    {
        public bool IsCodeValid(PostCode code)
        {
            return code.Prefix() >= 61 && code.Prefix() <= 63;
        }
    }
}