using DevicesMarket.Domain.Repositories.EntityFramework;
using DevicesMarket.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using System.Security.Policy;
using System.Text;

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

        public IActionResult Main(bool isAsp, string name)
        {
            ViewBag.Main = "current";
            return View(new MainViewModel { name = name, isAsp = isAsp });
        }

        public IActionResult Contacts()
        {
            ViewBag.Contacts = "current";
            return View(new ContactsViewModel { count = 2345});
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


        [HttpPost]
        public ActionResult SendRate(string name, string message, string email = "")
        {
            RateViewModel.rates.Add(new RateViewModel(name, email, message));
            return RedirectToAction("Index");
        }
    }
}