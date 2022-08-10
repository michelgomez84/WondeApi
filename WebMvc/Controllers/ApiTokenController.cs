using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using WebMvc.Helper;
using WebMvc.Models;
using WondeApiModel;
using WondeApiServices.IServices;

namespace WebMvc.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class ApiTokenController : ControllerBase
    {
        IJwtUtils _jwtUtils;

        public ApiTokenController(IJwtUtils jwtUtils)
        {
            _jwtUtils = jwtUtils;
        }
        

        [HttpGet("Test")]
        public async Task<string> Test()
        {

            return "Hello World";
        }

        [HttpPost("getToken")]
        public async Task<object> getToken(TokenModel parameter)//string username, string password
        {
            if (!string.IsNullOrEmpty(parameter.accessId))
            {
                // should check in the database
                return new { AuthToken = _jwtUtils.GenerateToken(new Models.UserModel() {  id= parameter.accessId }) };
            }

            throw new System.Web.Http.HttpResponseException(System.Net.HttpStatusCode.Unauthorized);
        }
    }

}
