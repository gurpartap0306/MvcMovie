using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        //Get: /HelloWorld/
        
        public IActionResult Index()
        {
            // return "This is my default action...";
            return View();
        }

        //
        //Get: /HelloWorld/Welcome/
        // Requires using System.Text.Encodings.Web;

        public IActionResult Welcome(string name, int numTimes =1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

    }
}
