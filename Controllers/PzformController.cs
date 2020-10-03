using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Pegazeus.Controllers
{
    public class PzformController : Controller
    {
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
    }
}