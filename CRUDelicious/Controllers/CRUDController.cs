using System;
using Microsoft.AspNetCore.Mvc;

namespace CRUDelicious.Controllers
{
    public class CRUDController : Controller
    {
        [HttpGet("")]
        public IActionResult Welcome()
        {
            return View();
        }
        [HttpGet("/new")]
        public IActionResult New()
        {
            return View();
        }
    }
}