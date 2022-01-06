using Microsoft.AspNetCore.Mvc;
using PCO.Application.Interfaces;
using System.Threading.Tasks;

namespace PCO.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _userService.GetUsers());
        }
    }
}
