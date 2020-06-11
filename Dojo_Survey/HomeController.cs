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
            return View("Create");
        }

        // [HttpGet("/result")]
        // public ViewResult Result()
        // {
        //     return View();
        // }

        [HttpPost("/result")]
        public ViewResult Result(Survey surveyResult)
        {
            return View("Submission",surveyResult);
        }

        [HttpPost("survey")]
        public IActionResult Submission(Survey yourSurvey)
        {
            return View();
        }
        [HttpPost("survey/create")]
        public IActionResult Create(Survey yourSurvey)
        {
            // Handle your form submission here
            if(ModelState.IsValid)
            {
                return RedirectToAction("Result");
            }
            else
            {
                return View("Create");
            }
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