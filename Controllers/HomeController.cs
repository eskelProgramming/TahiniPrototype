using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TahiniPrototype.Models;

namespace TahiniPrototype.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Food()
        {
            return View();
        }

        public IActionResult Lodging()
        {
            return View();
        }

        public IActionResult ToDo()
        {
            return View();
        }

        public IActionResult Transportation()
        {
            return View();
        }

        public IActionResult FAQ()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
