using DemoAsp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoAsp.Controllers
{
    public class AProposController : Controller
    {

        public string Index()
        {
            return "Je suis la page à propos...";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
