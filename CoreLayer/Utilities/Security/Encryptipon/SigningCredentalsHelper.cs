using Microsoft.IdentityModel.Tokens;

namespace CoreLayer.Utilities.Security.Encryptipon
{
    public class SigningCredentalsHelper
    {
        public static SigningCredentials CreateSigningCredentals(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha512Signature);
        }
    }
}