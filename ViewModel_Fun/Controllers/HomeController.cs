using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModel_Fun.Models;

namespace ViewModel_Fun.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpGet("/message")]
        public IActionResult Message()
        {
            Stringa myString = new Stringa()
            {
                Message = "This is some kind of crazy"
            };
            return View(myString);
        }
        [HttpGet("/numbers")]
        public IActionResult Numbers()
        {
            int [] numbers = new int[]
            {
                1,2,3,10,43,5
            };

            return View(numbers);
        }

        [HttpGet("/users")]
        public IActionResult Users()
        {
            List<User> users = new List<User>

            return View(numbers);
        }
    }
}
