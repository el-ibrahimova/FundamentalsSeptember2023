using Microsoft.AspNetCore.Mvc;

namespace SoftUniDemo.Controllers
{
    public class GamesController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
