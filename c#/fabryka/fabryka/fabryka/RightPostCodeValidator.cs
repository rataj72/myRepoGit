namespace fabryka
{
    public class RightPostCodeValidator : RightBase
    {
        public override bool IsCodeValid(Province province, string code)
        {
            IPostCodeExtractor extractor = new PostCodeExtractor();
            var codeEntity = extractor.GetPostCode(code);

            return PostCodeValidatorFactory.CreateProviceValidator(province).IsCodeValid(codeEntity);
        }
    }
}