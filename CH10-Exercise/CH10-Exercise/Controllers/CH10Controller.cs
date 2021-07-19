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
            string html = $"{"<form method='post' action='/CH10/hello'>"}{"<input type = 'text' name = 'name'/>"}{"<select name = 'language'><option value='English'>English</option><option value='Espanol'>Espanol</option><option value='Italiano'>Italiano</option><option value='Irish'>Irish</option><option value='Portuguese'>Portuguese</option>" }{"<input type = 'Submit' Value = 'Greet Me!'/>"}{"</form> "}";
            return Content(html, "text/html");
        }

        //Get /hello/welcome/{string parameter"}
        //[HttpGet("welcome/{name?}")]
        //[HttpPost]
        //public IActionResult Welcome(string name = "World")
        //{

        //    return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        //}

        [HttpGet]
        [HttpPost]
        [Route("hello")]
        public IActionResult CreateMessage(string name, string language)
        {
            switch (language)
            {
                case "English":
                    return Content("<h1>Hello, " + name + "!</h1>", "text/html");
                case "Espanol":
                    return Content("<h1>Hola, " + name + "!</h1>", "text/html");
                case "Italiano":
                    return Content("<h1>Ciao, " + name + "!</h1>", "text/html");
                case "Irish":
                    return Content("<h1>Dia dhuit, " + name + "!</h1>", "text/html");
                case "Portuguese":
                    return Content("<h1>Ola, " + name + "!</h1>", "text/html");
                default:
                    return Content("<h1>Hello, " + name + "!</h1>", "text/html");
            }
        }
    }
}
