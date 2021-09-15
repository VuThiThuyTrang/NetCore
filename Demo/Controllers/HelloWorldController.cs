using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Demo.Controllers
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

        public IActionResult GetName(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Xin chào" + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}