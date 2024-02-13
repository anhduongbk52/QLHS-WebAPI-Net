using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Model.Models;
using QLHS_WEB_API.Dtos;
using QLHS_WEB_API.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace QLHS_WEB_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class UserController:ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }       
        [HttpGet("GetFullNameByUserName")]
        public IActionResult GetFullNameByUserName()
        {
            try
            {
                var claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
                string someClaim = claimsIdentity.FindFirst("UserName").Value;
                string result = _userService.GetFullNameByUserName(someClaim);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message +"---"+ ex.StackTrace);
            }
        }        
    }
}
