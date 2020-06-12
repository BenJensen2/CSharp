using System;
using CRUDelicious.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CRUDelicious.Controllers
{
    public class CRUDController : Controller
    {
        private CRUDContext db;
     
        // here we can "inject" our context service into the constructor
        public CRUDController(CRUDContext context)
        {
            db = context;
        }
        [HttpGet("")]
        public IActionResult Welcome()
        {
            List<Dish> allDishes = db.Dishes.ToList();
            return View("Welcome",allDishes);
        }
        [HttpGet("/new")]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost("/create")]
        public IActionResult Create(Dish newDish)
        {
            if(ModelState.IsValid == false)
            {
                return View("New");
            }
            db.Dishes.Add(newDish);
            db.SaveChanges();
            return RedirectToAction("Details");
        }

        [HttpGet("/1")]
        public IActionResult Details()
        {
            return View();
        }
        [HttpPost("/1/delete")]
        public IActionResult Delete()
        {
            return RedirectToAction("Welcome");
        }
        [HttpGet("edit/1")]
        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost("/edit/1/update")]
        public IActionResult Update()
        {
            return RedirectToAction ("Edit");
        }
    }
}   