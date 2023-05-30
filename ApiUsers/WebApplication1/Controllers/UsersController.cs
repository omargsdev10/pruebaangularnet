using Microsoft.AspNetCore.Mvc;

namespace _1ApiUsers.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
