using Microsoft.AspNetCore.Mvc;
using QLHS_WEB_API.Services;

namespace QLHS_WEB_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController:ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        //https://localhost:5065/api/user/GetFullNameByUserName
        //http://192.168.11.12:5065/user/GetFullNameByUserName
        [HttpGet("GetFullNameByUserName")]
        public IActionResult GetFullNameByUserName(string userName)
        {
            try
            {
                var fullName = _userService.GetFullNameByUserName(userName);
                return Ok(fullName);
            }
           catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("TEST")]
        public IActionResult TEST()
        {
            
            return Ok("Hello");
        }
    }
}
