using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Wedding_Planner.Models;
// using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace CSharp.Controllers
{
    public class LogRegController : Controller
    {

// Sets db as a CSharp Context object
        private WeddingContext db;

// Controller Constructor sets context file to db
//   - Creates a new controller object everytime a function is run
        public LogRegController(WeddingContext context)
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
        
        

        [HttpGet("")]
        public IActionResult Welcome()
        {
// Views the Welcome Page
            return View();
        }



// Post needed for form data
        [HttpPost("/submitRegister")]
        public IActionResult submitRegister(User newUser)
        {

// Checks to see if information in the form is filled out correctly
            if(ModelState.IsValid == false)
            {
                return View("Welcome");
            }

// Checks to see if the user email is already used
            if (db.Users.Any(user => user.Email == newUser.Email))
            {
                ModelState.AddModelError("Email", "That email is already taken. Please choose another");
            }

// Creates Password
            PasswordHasher<User> hasher = new PasswordHasher<User>();
            newUser.Password = hasher.HashPassword(newUser, newUser.Password);

// Adds User to database: Table: Users
            db.Users.Add(newUser);
            db.SaveChanges();

// Adds the user ID, First Name and Last Name to Session
            HttpContext.Session.SetInt32("UserId", newUser.UserId);
            HttpContext.Session.SetString("FirstName", newUser.FirstName);
            HttpContext.Session.SetString("LastName", newUser.LastName);

// Redirects to the Dashboard
            return RedirectToAction ("Dashboard","Wedding");
        }



        [HttpGet("/success")]
        public IActionResult Success()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Welcome");
            }
            return View();
        }



        [HttpGet("/login")]
        public IActionResult Login()
        {
            return View("Success");
        }
        


        [HttpPost("/submitLogin")]
        public IActionResult submitLogin(LoginUser loginUser)
        {

// Checks to see if information in the form is filled out correctly
            if(ModelState.IsValid == false)
            {
                return View("Welcome");
            }

// Finds the user in the database
            User oneUser = db.Users.FirstOrDefault(user => user.Email == loginUser.LoginEmail);

// Creates Login Error
            string loginError = "Incorrect Email/Password or User does not exist";
            
//  If no user in the database, returns login error
            if(oneUser==null)
            {
                ModelState.AddModelError("LoginEmail", loginError);
                return View("Login");
            }

// Checks the password
            PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
            PasswordVerificationResult pwCompareResult = hasher.VerifyHashedPassword(loginUser, oneUser.Password, loginUser.LoginPassword);

// If password is incorrect, returns login error
            if (pwCompareResult == 0)
            {
                ModelState.AddModelError("LoginEmail", loginError);
                return View("Login");
            }

// Adds the user ID, First Name and Last Name to Session
            HttpContext.Session.SetInt32("UserId", oneUser.UserId);
            HttpContext.Session.SetString("FirstName", oneUser.FirstName);
            HttpContext.Session.SetString("LastName", oneUser.LastName);

            return RedirectToAction ("Dashboard","Wedding");
        }



        [HttpGet("/logout")]
        public IActionResult Logout()
        {
// Clears out session and returns to the Welcome page
            HttpContext.Session.Clear();
            return View("Welcome");
        }
    }
}