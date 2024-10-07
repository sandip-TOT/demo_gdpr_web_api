using GdprCompliantWebApi.Models;
using GdprCompliantWebApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GdprCompliantWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserRepository _userRepository;

        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] User user)
        {
            await _userRepository.CreateUser(user);
            return CreatedAtAction(nameof(GetAll), new { id = user.Id }, user);
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAll()
        {
            return await _userRepository.GetAllUsers();
        }
    }
}
