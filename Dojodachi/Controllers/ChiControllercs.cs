using System;
using Microsoft.AspNetCore.Mvc;
using Dojodachi.Models;
namespace Dojodachi.Controllers
{
    public class ChiController : Controller 
    {
        [HttpGet("/dojodachi")]
        public IActionResult Status()
        {
            Chi myChi = new Chi();
            return View("Status",myChi);
        }
        public IActionResult Feed()
        {
            Console.WriteLine("\nFeeding\n");
            return View("Status");
        }
        public IActionResult Play()
        {
            Console.WriteLine("\nPlaying\n");
            return View("Status");
        }public IActionResult Work()
        {
            Console.WriteLine("\nWorking\n");
            return View("Status");
        }public IActionResult Sleep()
        {
            Console.WriteLine("\nSleeping\n");
            return View("Status");
        }
    }
}