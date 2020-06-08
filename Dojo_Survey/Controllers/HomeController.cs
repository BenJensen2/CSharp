using System;
using Dojo_Survey.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dojo_Survey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Survey()
        {
            // ViewBag.trello = "Sadie";
            return View();
        }

        // [HttpGet("/result")]
        // public ViewResult Result()
        // {
        //     return View();
        // }

        [HttpPost("/result")]
        public ViewResult Result(Ninja newNinja)
        {
            return View("Result",newNinja);
        }

        [HttpPost("survey")]
        public IActionResult Submission(Survey yourSurvey)
        {
            // Handle your form submission here
            return View(yourSurvey);
            
        }



        // [HttpGet("/travel/{destination}")]
        // public RedirectToActionResult NotSure(string destination)
        // {
        //     Console.WriteLine($"\n mike: {destination} \n");

        //     return RedirectToAction("Result");
        // }

        // [HttpGet("/travel2/{destination}")]
        // public RedirectToActionResult NotSure(string destination)
        // {
        //     Console.WriteLine($"\n mike Hello: {destination} \n");

        //     return RedirectToAction("Result");
        // }

        [HttpGet("/redirect")]
        public RedirectToActionResult Thello()
        {
            return RedirectToAction("Result");
        }



    }
}