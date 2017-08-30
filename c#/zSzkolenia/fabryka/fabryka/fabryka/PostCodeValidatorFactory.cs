using System;
using System.Collections.Generic;
using fabryka.Provinces;

namespace fabryka
{
    public static class PostCodeValidatorFactory
    {
        private static Dictionary<Province, Func<IProviceValidator>> validatorMap = new Dictionary<Province, Func<IProviceValidator>>()
        {
            {Province.Dolnosloskie , () => new SilesianValidator()},
            {Province.Wielkopolskie , () => new GreatPolandValidator()},
            {Province.Mazowieckie , () => new MazowianValidator()}
        };

        public static IProviceValidator CreateProviceValidator(Province province)
        {
            return validatorMap[province]();
        }
    }
}