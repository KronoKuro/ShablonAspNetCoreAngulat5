using Microsoft.AspNetCore.Mvc;

namespace Appli.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}