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
        // 
        // GET: /Pegazeus/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /Pegazeus/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}