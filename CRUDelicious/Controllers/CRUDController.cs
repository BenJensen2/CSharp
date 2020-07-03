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
            Console.WriteLine("\n" + newDish.Tastiness +"\n");
            // string to int ""
            if(ModelState.IsValid == false)
            {
                return View("New");
            }
            db.Dishes.Add(newDish);
            db.SaveChanges();
            return RedirectToAction("Details",new {id = newDish.DishId});
        }

        
        [HttpGet("/{id}")]
        public IActionResult Details(int id)
        {
            Dish selectedDish = db.Dishes.FirstOrDefault(dish => dish.DishId == id);

            if (selectedDish == null)
            {
                return RedirectToAction("Welcome");
            }

            return View("Details", selectedDish);
        }


        
        [HttpGet("/edit/{id}")]
        public IActionResult Edit(int id)
        {
            Dish selectedDish = db.Dishes.FirstOrDefault(dish => dish.DishId == id);
            if (selectedDish == null)
            {
                return RedirectToAction("Details",selectedDish.DishId);
            }
            return View("Edit",selectedDish);
        }


        [HttpPost("/edit/{id}/update")]
        public IActionResult Update(Dish editedDish, int id)
        {
            if(ModelState.IsValid == false)
            {
                editedDish.DishId = id;
                return View("Edit",editedDish);
            }
            Dish selectedDish = db.Dishes.FirstOrDefault(dish => dish.DishId == id);

            if (selectedDish == null)
            {
                return RedirectToAction("Welcome");
            }
            
            selectedDish.Name = editedDish.Name;
            selectedDish.Chef = editedDish.Chef;
            selectedDish.Calories = editedDish.Calories;
            selectedDish.Tastiness = editedDish.Tastiness;
            selectedDish.Description = editedDish.Description;
            selectedDish.UpdatedAt = DateTime.Now;
            
            db.Dishes.Update(selectedDish);
            db.SaveChanges();

            return RedirectToAction("Details",new {id = selectedDish.DishId});
        }


        [HttpGet("/{id}/delete")]
        public IActionResult Delete(int id)
        {
            Dish selectedDish = db.Dishes.FirstOrDefault(dish => dish.DishId == id);

            if (selectedDish != null)
            {
                db.Dishes.Remove(selectedDish);
                db.SaveChanges();
            }
            return RedirectToAction("Welcome");
        }
    }
}   