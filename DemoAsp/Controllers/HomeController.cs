using DemoAsp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoAsp.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        // /Home/SayHello
        public string SayHello()
        {
            return "Bonjour Hello !!";
        }

        // /Home/SayHelloA?person=Anthony
        public string SayHelloA(string person)
        {
            return $"Bonjour Hello {person} !!";
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public string Contact()
        {
            return "Je suis la page pour afficher les contacts...";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}