using System.Collections.Generic;
using CoreLayer.Entities.Concrute;

namespace CoreLayer.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}