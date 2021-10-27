using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 


        // Pasamos como parametros 2 variables y le llamaremos en la URL
        /*public string Welcome( string nombre , int edad=1)
        {
            return HtmlEncoder.Default.Encode($"Hola {nombre}, tu edad es : {edad}");
        }*/

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

    }
}