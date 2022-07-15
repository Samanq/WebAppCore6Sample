using Microsoft.AspNetCore.Mvc;
using WebAppCore6Sample.Api.DataContexts;
using WebAppCore6Sample.Api.Entities;
using WebAppCore6Sample.Api.Repositories;
using WebAppCore6Sample.Api.Repositories.Interfaces;

namespace WebAppCore6Sample.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(DataContext dataContext)
        {
            _userRepository = new UserRepository(dataContext);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _userRepository.GetAll();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            return Ok(await _userRepository.GetById(id));
        }

        [HttpGet("{email}")]
        public async Task<IActionResult> GetByEmail(string email)
        {
            return Ok(await _userRepository.GetByEmail(email));
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> Edit([FromBody] User user, long id)
        {
            if (id != user.Id) return BadRequest();

            await _userRepository.Edit(user);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await _userRepository.Delete(id);

            return Ok();
        }
    }
}
