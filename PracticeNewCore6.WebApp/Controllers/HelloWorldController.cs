using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace PracticeNewCore6.WebApp.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }
        public string Index2()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        //https://localhost:7028/HelloWorld/Welcome?name=Rick&numtimes=4
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
        public string Welcome1()
        {
            return "This is the Welcome action method...";
        }

        //https://localhost:7028/HelloWorld/Welcome2?name=Rick&numtimes=4
        public string Welcome2(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

        //https://localhost:7028/HelloWorld/Welcome3/3?name=Rick
        public string Welcome3(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}
