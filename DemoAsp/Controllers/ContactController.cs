using DemoAsp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoAsp.Controllers
{
    public class ContactController : Controller
    {

        public IActionResult Index()
        {
            List<string> contacts = new List<string>()
            {
                "Michael", 
                "John", 
                "Sahra", 
                "Anthony", 
                "Sacha" 
            };

            // méthode 1: ViewData
            ViewData["Contacts"] = contacts;

            // méthode 2: ViewBag
            ViewBag.LesContacts = contacts;

            // méthode 3: par un Model
            Marmoset ouistiti = new Marmoset()
            {
                Id = 1,
                Name = "Babouche",
                Age = 3
            };

            //return View(ouistiti);

            // on peut retourner la liste directement
            return View(contacts);
        }

        public IActionResult Details(int? id)
        {
            return View(id);
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return RedirectToAction(nameof(Index)); // on repasse par l'action "Index" (/Contact/Index)
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
