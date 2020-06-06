using System;
using Microsoft.AspNetCore.Mvc;

namespace TimeDisplay
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult MyTime()
        {
            DateTime CurrentTime = DateTime.Now;
            ViewBag.day = CurrentTime.ToString("MMMM dd yyyy");
            ViewBag.time = CurrentTime.ToString("HH:mm tt");
            return View();
        }
    }



}