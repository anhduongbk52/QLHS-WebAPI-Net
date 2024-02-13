using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using QLHS_WEB_API.Dtos;
using QLHS_WEB_API.Helper;
using QLHS_WEB_API.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace QLHS_WEB_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController: ControllerBase
    {
        public static int LOGIN_ATTEMPT_MAX = 5;
        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;
        public AuthenticationController(IConfiguration configuration, IUserService userService)
        {
            _configuration = configuration;
            _userService= userService;
        }
        [HttpPost("Auth")]
        public IActionResult Authenticate(UserDto userDto)
        {
            try
            {
                if (userDto.Password is null)
                {
                    return BadRequest("Password is null");
                }
                else
                {
                    //var passEncode = Convert.ToBase64String(CryptoUtil.HashPassword(Encoding.UTF8.GetBytes(userDto.Password), CryptoUtil.GetSalt(userDto.UserName)));
                    var result = _userService.Validate(userDto.UserName, userDto.Password);
                    switch (result)
                    {
                        case Model.Models.LoginResult.Success:
                            var issuer = _configuration["JwtConfig:Issuer"];
                            var audience = _configuration["JwtConfig:Audience"];
                            var keyConfig = _configuration["JwtConfig:Key"];
                            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(keyConfig));
                            var jwtHandle = new JwtSecurityTokenHandler();
                            var key = Encoding.ASCII.GetBytes(keyConfig);
                            var tokenDes = new SecurityTokenDescriptor
                            {
                                Subject = new ClaimsIdentity(new[]
                                {
                                    new Claim("UserName", userDto.UserName)
                                }),
                                Expires = DateTime.UtcNow.AddHours(6),
                                Audience = audience,
                                Issuer = issuer,
                                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                            };
                            var jwtToken = jwtHandle.CreateToken(tokenDes);
                            var token = jwtHandle.WriteToken(jwtToken);
                            return Ok(token);
                        case Model.Models.LoginResult.InvalidUsernameOrPassword:
                            return BadRequest("Invalid username or password");
                        case Model.Models.LoginResult.AccountLocked:
                            return BadRequest("Your account has been locked. Please contact the administrator.");
                        case Model.Models.LoginResult.MAX_ATTEMPT_COUNT:
                            return BadRequest("You have reached the maximum login attempts. Please try again later.");
                        default:
                            return BadRequest("Unknown error");
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + "---" + ex.StackTrace);
            }
        }
    }
}
