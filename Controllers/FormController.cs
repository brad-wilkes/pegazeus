using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Pegazeus.Models;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace Pegazeus.Controllers
{
    public class FormController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // POST: Pzform/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                //Method 1: Using Component Name  

                ViewData["Name"] = collection["Name"];
                ViewData["City"] = collection["City"];
                ViewData["Address"] = collection["Address"];
                ViewData["City"] = collection["City"];
                ViewData["Zip"] = collection["Zip"];
                ViewData["Email"] = collection["Email"];

               /* Method 2: Using Component Index Position
                ViewData["Firstname"] = collection[1];
                ViewData["Lastname"] = collection[2];
                ViewData["Address"] = collection[3];
                ViewData["City"] = collection[4];
                ViewData["Zip"] = collection[5];
                ViewData["Email"] = collection[6]; */

                return View("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: /Pegazeus/
        public string Index()
        {
            return "This is default";
        }
        // GET: /Pegazeus/Welcome/ 
        public string Welcome()
        {
            return "This is the default Welcome action";
        }

        public string FirstName(string Firstname)
        {
            string input = Firstname;
            return input;
        }

        public string LastName(string Lastname)
        {
            string input = Lastname;
            return input;
        }

        public string Address(string Address)
        {
            string input = Address;
            return input;
        }

        public string City(string City)
        {
            string input = City;
            return input;
        }

        public int Zip(int Zip)
        {
            int input = Zip;
            return input;
        }

        public string Email(string Email)
        {
            string input = Email;
            return input;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}