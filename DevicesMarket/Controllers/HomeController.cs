using DevicesMarket.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DevicesMarket.Controllers
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
            ViewBag.Index = "current";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Main()
        {
            ViewBag.Main = "current";
            return View();
        }

        public IActionResult Contacts()
        {
            ViewBag.Contacts = "current";
            return View();
        }

        public IActionResult Delivery()
        {
            ViewBag.Delivery = "current";
            return View();
        }

        public IActionResult Partners()
        {
            ViewBag.Partners = "current";
            return View();
        }

        public IActionResult Catalog()
        {
            ViewBag.Catalog = "current";
            return View();
        }

        public IActionResult Program()
        {
            ViewBag.Program = "current";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}