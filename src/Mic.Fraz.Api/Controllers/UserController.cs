using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mic.Fraz.BusinessInterfaces;

namespace Mic.Fraz.Api.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserManager _userManager;

        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        // GET api/user/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _userManager.GetAsync(id);
            return Ok(result);
        }

    }

  
}
