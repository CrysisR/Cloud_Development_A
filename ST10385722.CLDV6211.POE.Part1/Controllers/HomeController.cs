using Microsoft.AspNetCore.Mvc;
using ST10385722.CLDV6211.POE.Part1.Models;
using System.Diagnostics;

namespace ST10385722.CLDV6211.POE.Part1.Controllers
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

        public IActionResult aboutus()
        {
            return View();
        }

        public IActionResult contactus()
        {
            return View();
        }

        public IActionResult mywork()
        {
            return View();
        }

        public IActionResult privacypolicy()
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
