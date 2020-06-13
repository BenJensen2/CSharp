using LoginRegistration.Models;
using Microsoft.AspNetCore.Mvc;

namespace LoginRegistration.Controllers
{
    public class LogRegController : Controller
    {
        private LogRegContext db;
     
        // here we can "inject" our context service into the constructor
        public LogRegController(LogRegContext context)
        {
            db = context;
        }
        
        
        [HttpGet("")]
        public IActionResult Registration()
        {
            return View();
        }


        [HttpGet("/login")]
        public IActionResult Login()
        {
            return View();
        }
    }
}