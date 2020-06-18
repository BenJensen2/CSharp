using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wedding_Planner.Models;

namespace Wedding_Planner.Controllers
{
    public class WeddingController: Controller
    {
        private WeddingContext db;
     
        public WeddingController(WeddingContext context)
        {
            db = context;
        }

        private int? uid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserId");
            }
        }

        private bool isLoggedIn
        {
            get
            {
                return uid != null;
            }
        }


        [HttpGet("/new")]
        public IActionResult New()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Welcome","LogReg");
            }
            return View();
        }



        [HttpPost("/create")]
        public IActionResult Create(Wedding newWedding)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Welcome","LogReg");
            }
            if(ModelState.IsValid == false)
            {
                return View("New");
            }
            
            newWedding.Planner =  db.Users.FirstOrDefault(user => user.UserId == uid);
            db.Weddings.Add(newWedding);
            // RSVP newRSVP = new RSVP();
            // newRSVP.WeddingId = newWedding.WeddingId;
            // newRSVP.UserId = newWedding.Planner.UserId;
            db.SaveChanges();
            return RedirectToAction("Details",new {id = newWedding.WeddingId});
        }


        [HttpGet("/dashboard")]
        public IActionResult Dashboard()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Welcome","LogReg");
            }
            
            Dashboard dashboardWeddings = new Dashboard();
            dashboardWeddings.loggedUser =  db.Users.FirstOrDefault(user => user.UserId == uid);
            List<Wedding> weddingList = db.Weddings
                .Include(wedding => wedding.GuestList)
                .ToList();
            dashboardWeddings.allWeddings = weddingList;
            return View("Dashboard",dashboardWeddings);
        }


        [HttpGet("/details/{id}")]
        public IActionResult Details(int id)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Welcome","LogReg");
            }

            Wedding currentWedding = db.Weddings.FirstOrDefault(wid => wid.WeddingId == id);
            return View("Details",currentWedding);
        }


        [HttpGet("/details/{id}/RSVP")]
        public IActionResult RSVP(int id)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Welcome","LogReg");
            }

// Create new RSVP
//  - Add Wedding & User ID to it
//  - Add new RSVP to Database
//  - Save Changes
            RSVP newRSVP = new RSVP();
            newRSVP.WeddingId = id;
            newRSVP.UserId = (int)uid;
            db.RSVPs.Add(newRSVP);
            db.SaveChanges();

            return RedirectToAction("Details",new {id = id}); //Why do we have to put new?
        }
    }

}