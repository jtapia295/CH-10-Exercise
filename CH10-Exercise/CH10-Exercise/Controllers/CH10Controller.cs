using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CH10_Exercise.Controllers
{
    [Route("/CH10")]
    public class CH10Controller : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html =$"{"<form method='post' action='/CH10'>"}{"<input type = 'text' name = 'name'/>"}{"<input type = 'Submit' Value = 'Greet Me!'/>"}{"</form> "}";
            return Content(html,"text/html");
        }

        //Get /hello/welcome/{string parameter"}
        [HttpGet("welcome/{name?}")]
        [HttpPost]
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }
    }
}
