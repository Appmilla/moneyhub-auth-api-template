using Appmilla.Moneyhub.Refit.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Moneyhub.Auth.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoneyhubAccessController : ControllerBase
    {
        private readonly IAccessToken _accessToken;

        public MoneyhubAccessController(IAccessToken accessToken)
        {
            _accessToken = accessToken;
        }

        [Authorize]
        [HttpGet(Name = "GetMoneyhubAcces")]
        public async Task<ActionResult<AccessTokenResponse>> Get()
        {
            AccessTokenResponse? accessTokenResponse = null;
            try
            {
                accessTokenResponse = await _accessToken.GetAccessToken(new AccessTokenRequest() { GrantType = "client_credentials", Scope = "accounts:read savings_goals:read", Sub = "61ac9b75220d4100a72e17a2" });
            }
            catch (Exception e)
            {
                return new BadRequestObjectResult("Error: " + e.Message);
            }
            return new OkObjectResult(accessTokenResponse);
        }
    }
}