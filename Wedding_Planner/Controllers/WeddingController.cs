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

// Gets the user ID from session everytime uid is called
        private int? uid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserId");
            }
        }


// Returns user ID if logged in: 
//   - If uid does not = null
//      - Would not return if uid = null 
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
// Check if logged in
            if (!isLoggedIn)
            {
                return RedirectToAction("Welcome","LogReg");
            }
//  Check if inputs are correct
            if(ModelState.IsValid == false)
            {
                return View("New");
            }
//  Add logged in user to Wedding as planner
            newWedding.UserId = (int)uid;
//  Add wedding to database
            db.Weddings.Add(newWedding);
//  Save database
            db.SaveChanges();
//  Return new wedding to view details
//      - Must create new id for details routing
            return RedirectToAction("Details",new {id = newWedding.WeddingId});
        }

        [HttpGet("/wedding/delete")]
        public IActionResult Delete(int id)
        {
// Check if logged in
            if (!isLoggedIn)
            {
                return RedirectToAction("Welcome","LogReg");
            }
//  Query weddings table to find wedding to delete
            Wedding weddingToDelete = db.Weddings.FirstOrDefault(wedding => wedding.WeddingId == id);
//  Hackers no hacking!
            if(weddingToDelete == null)
            {
                return RedirectToAction("Welcome","LogReg");
            }
//  Remove wedding from database
            db.Weddings.Remove(weddingToDelete);
//  Save database
            db.SaveChanges();

//  Return to dashboard
            return RedirectToAction("Dashboard");
        }


        [HttpGet("/dashboard")]
        public IActionResult Dashboard()
        {
// Check if logged in
            if (!isLoggedIn)
            {
                return RedirectToAction("Welcome","LogReg");
            }
            User userLoggedIn = db.Users.FirstOrDefault(user => user.UserId == uid);
//  Creates new Dashboard ViewModel with User and Wedding
            ViewModel dashboardWeddings = new ViewModel();
//  Assigns Logged User to Dashboard model
            dashboardWeddings.loggedUser =  userLoggedIn;
//  Queries for list of all weddings
            List<Wedding> weddingList = db.Weddings
//  Includes GuestList with each wedding
                .Include(wedding => wedding.GuestList)
                .ThenInclude(rsvp => rsvp.Guest)
//  Creates Query into list
                .ToList();
//  Loop through each wedding
            foreach(Wedding wedding in weddingList)
            {
//  Loop through each RSVP in the wedding
                foreach(RSVP rsvp in wedding.GuestList)
                {
                    // TODO Transfer to View side
//  - see if logged in user is RSVPed to the wedding & store it
                    if(rsvp.UserId == uid)
                    {
                        wedding.loggedUserRSVPed = true;
                    }
                }
            }
   
//  Adds weddingList to Dashboard ViewModel
            dashboardWeddings.allWeddings = weddingList;
//  Returns Dashboard with Dashboard ViewModel
            return View("Dashboard",dashboardWeddings);
        }


        [HttpGet("/details/{id}")]
        public IActionResult Details(int id)
        {
//  Check if logged in
            if (!isLoggedIn)
            {
                return RedirectToAction("Welcome","LogReg");
            }
//  Querys Wedding Table
            Wedding currentWedding = db.Weddings
//  Includes the List<RSVP> GuestList
            .Include(wedding => wedding.GuestList)
            .ThenInclude(rsvp => rsvp.Guest) //nested include
            // .ToList() Would be all weddings
//  Finds current wedding based on wedding id
            .FirstOrDefault(wedding => wedding.WeddingId == id);


//  Creates new ViewModel to pass
            ViewModel weddingDetails = new ViewModel();
//  Adds current wedding to new ViewModel
            weddingDetails.Wedding = currentWedding;

//  Query User table for RSVP containing
            RSVP currentRSVP = db.RSVPs
            .FirstOrDefault(
//  - Logged User
            rsvp => rsvp.UserId == uid 
//  - and
            && 
//  - current wedding
            rsvp.WeddingId == id);

//  Returns the details view of the wedding ViewModel
            return View("Details",weddingDetails);
        }


        [HttpGet("/details/{id}/RSVP")]
        public IActionResult RSVP(int id)
        {
//  Check if logged in
            if (!isLoggedIn)
            {
                return RedirectToAction("Welcome","LogReg");
            }

//  Query User table for RSVP containing
            RSVP currentRSVP = db.RSVPs
            .FirstOrDefault(
//  - Logged User
            rsvp => rsvp.UserId == uid 
//  - and
            && 
//  - current wedding
            rsvp.WeddingId == id);

//  if there is no RSVP with this user and wedding, add one: No Hackers!!! 
            if(currentRSVP == null)
            {
// Create new RSVP
                RSVP newRSVP = new RSVP();
//  - Add Weddingid to RSVP
                newRSVP.WeddingId = id;
//  - Add Userid to RSVP
                newRSVP.UserId = (int)uid;
//  - Query User table and add logged user to RSVP
                newRSVP.Guest = db.Users.FirstOrDefault(user => user.UserId == uid);
//  - Add new RSVP to Database
                db.RSVPs.Add(newRSVP);
//  - Save Changes
                db.SaveChanges();
//  Redirects to details of current wedding with new id
                return RedirectToAction("Details",new {id = id}); //Why do we have to put new?
            }
            return RedirectToAction("Dashboard");
        }

        [HttpGet("/details/{id}/unRSVP")]
        public IActionResult unRSVP(int id)
        {
//  Check if logged in
            if (!isLoggedIn)
            {
                return RedirectToAction("Welcome","LogReg");
            }
//  Query User table for RSVP containing
            RSVP currentRSVP = db.RSVPs
            .FirstOrDefault(
//  - Logged User
            rsvp => rsvp.UserId == uid 
//  - and
            && 
//  - current wedding
            rsvp.WeddingId == id);
//  if there is still an RSVP, remove it
            if(currentRSVP!= null)
            {
//  Delete current RSVP
                db.RSVPs.Remove(currentRSVP);
//  - Save Changes
                db.SaveChanges();
            }

//  Redirects to dashboard with RSVP button now available
            return RedirectToAction("Dashboard");
        }
    }

}