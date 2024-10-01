using Microsoft.AspNetCore.Mvc;

namespace Projects.Controllers.Auth
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
