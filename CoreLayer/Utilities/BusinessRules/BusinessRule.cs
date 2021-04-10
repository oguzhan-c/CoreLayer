using CoreLayer.Utilities.Results.Abstruct;

namespace CoreLayer.Utilities.BusinessRules
{
    public class BusinessRule
    {
        public static IResult Run(params IResult [] logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.Succcess)
                {
                    return logic;
                }
            }
            return null;
        }
    }
}
