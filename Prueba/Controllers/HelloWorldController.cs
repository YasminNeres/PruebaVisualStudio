using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "Hola Yasmin";
        }

        // 
        // GET: /HelloWorld/Welcome/ 


        // Pasamos como parametros 2 variables y le llamaremos en la URL
        /*public string Welcome( string nombre , int edad=1)
        {
            return HtmlEncoder.Default.Encode($"Hola {nombre}, tu edad es : {edad}");
        }*/

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hola {name}, ID: {ID}");
        }

    }
}