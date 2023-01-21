using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WS.Application.UserService;
using WS.Application.UserService.Dtos;

namespace WS.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;

        public UsersController(IUserService service)
        {
            _service = service;
        }

        [HttpPost("authenticate")]
        [AllowAnonymous]
        
        public async Task<IActionResult> Authenticate([FromBody] LoginRequest request)
        {
            var result = await _service.Authenticate(request);
            if(string.IsNullOrEmpty(result))
            {
                return BadRequest("Username or Password is incorrect") ;
            }
            return Ok(result);
        }

        [HttpPost("register")]
        [AllowAnonymous]

        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _service.Register(request);
            if(!result)
            {
                return BadRequest("Register ");
            }
            return Ok(new {token = result});
        }

        //http://localhost:8001/api/Users/paging
        [HttpGet("paging")]
        public async Task<IActionResult> GetListAsync([FromQuery]ListUserRequest request)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }    
            var result = await _service.GetListUser(request);
            return Ok(result);
        }    
    }
}
