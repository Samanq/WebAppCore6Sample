using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppCore6Sample.Api.DataContexts;
using WebAppCore6Sample.Api.Models;

namespace WebAppCore6Sample.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public AuthenticationController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost]
        [Route("Login")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            return Ok();
        }

        [HttpPost]
        [Route("register")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            return Ok();
        }

        //[HttpPost]
        //public async Task<IActionResult> RefreshToken()
        //{
        //    return Ok();
        //}

        //[HttpPost]
        //public async Task<IActionResult> Revoke()
        //{
        //    return Ok();
        //}

        //[HttpPost]
        //public async Task<IActionResult> RevoveAll()
        //{
        //    return Ok();
        //}
    }
}
