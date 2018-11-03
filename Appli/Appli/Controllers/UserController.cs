using Appli.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Appli.Controllers
{
    [Route("api/user")]
    public class UserController : Controller
    {
        private UserManager<ApplicationContext> _userManager;
        private IHostingEnvironment _env;
        public UserController(UserManager<ApplicationContext> userManager, IHostingEnvironment env)
        {
            _userManager = userManager;
            _env = env;
        }

        [HttpGet]
        public IActionResult Cabinet()
        {

            //var user = User.Identity.AuthenticationType;
            return Ok();
        }

        /*public User GetCurrentUser()
        {
            var user = await GetCurrentUserAsync();
            return user;
        }*/
    }
}