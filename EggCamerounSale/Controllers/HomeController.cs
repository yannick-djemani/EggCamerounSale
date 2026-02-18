using EggCamerounSale.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EggCamerounSale.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        /// <summary>
        /// Returns the default view for the controller.
        /// </summary>
        /// <returns>An IActionResult that renders the default view associated with the controller.</returns>
        public IActionResult Index()
        {
            ViewData["Greeting"] = _configuration["Greeting"];
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult DeploymentSlot()
        {
            return View();
        }
    }
}
