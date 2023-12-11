using Microsoft.AspNetCore.Mvc;
using SoftUniDemo.Models;
using System.Xml.Linq;


namespace SoftUniDemo.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(ILogger<HomeController> logger)
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Students()
        {
            List<Student> students = new List<Student>
            {
                new Student() { Name = "Ivan" },
                new Student() { Name = "Mitko" },
                new Student() { Name = "Desi" }
            };
            return View(students);
        }

    }
}
