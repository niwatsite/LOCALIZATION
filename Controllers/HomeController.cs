using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Localization.Models;
using Localization.Resources;

namespace Localization.Controllers
{
    public class HomeController : Controller
    {
        private LocService SharedLocalizer;

        public HomeController(LocService _sharedLocalizer)
        {
            SharedLocalizer = _sharedLocalizer;
        }

        public IActionResult Index()
        {
            var text = SharedLocalizer.GetLocalizedHtmlString("Home");
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
    }
}
