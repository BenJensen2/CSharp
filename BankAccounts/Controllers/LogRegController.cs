using System;
using System.Linq;
using BankAccounts .Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BankAccounts.Controllers
{
    public class LogRegController : Controller
    {
        private BankContext db;
     
        public LogRegController(BankContext context)
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
        
        
        [HttpGet("")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("/submitRegister")]
        public IActionResult submitRegister(User newUser)
        {
            if (ModelState.IsValid)
            {
                if (db.Users.Any(user => user.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "That email is already taken. Please choose another");
                }
            }

            if(ModelState.IsValid == false)
            {
                return View("Register");
            }

            PasswordHasher<User> hasher = new PasswordHasher<User>();
            newUser.Password = hasher.HashPassword(newUser, newUser.Password);

            db.Users.Add(newUser);
            db.SaveChanges();

            HttpContext.Session.SetInt32("UserId", newUser.UserId);
            HttpContext.Session.SetString("FirstName", newUser.FirstName);
            HttpContext.Session.SetString("LastName", newUser.LastName);

            // Used to create a nullable integer
            int? userId = HttpContext.Session.GetInt32("UserAge");
            string userFname = HttpContext.Session.GetString("FirstName");
            string userLname = HttpContext.Session.GetString("LastName");

            Console.WriteLine($"\n {userId} \n");
            Console.WriteLine($"\n {userFname} \n");
            Console.WriteLine($"\n {userLname} \n");

            return RedirectToAction ("Success");
        }

        [HttpGet("/success")]
        public IActionResult Success()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Register");
            }
            return View();
        }


        [HttpGet("/login")]
        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost("/submitLogin")]
        public IActionResult submitLogin(LoginUser loginUser)
        {
            if(ModelState.IsValid == false)
            {
                return View("Login");
            }

            User oneUser = db.Users.FirstOrDefault(user => user.Email == loginUser.LoginEmail);

            string loginError = "Incorrect Email/Password or User does not exist";
            
            if(oneUser==null)
            {
                ModelState.AddModelError("LoginEmail", loginError);
                return View("Login");
            }

            PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
            PasswordVerificationResult pwCompareResult = hasher.VerifyHashedPassword(loginUser, oneUser.Password, loginUser.LoginPassword);

            if (pwCompareResult == 0)
            {
                ModelState.AddModelError("LoginEmail", loginError);
                return View("Login");
            }

            Console.WriteLine("\n User exists \n");
            HttpContext.Session.SetInt32("UserId", oneUser.UserId);
            HttpContext.Session.SetString("FirstName", oneUser.FirstName);
            HttpContext.Session.SetString("LastName", oneUser.LastName);

            int? userId = HttpContext.Session.GetInt32("UserAge");
            string userFname = HttpContext.Session.GetString("FirstName");
            string userLname = HttpContext.Session.GetString("LastName");

            Console.WriteLine($"\n {userId} \n");
            Console.WriteLine($"\n {userFname} \n");
            Console.WriteLine($"\n {userLname} \n");



            return RedirectToAction ("Success");
        }

        [HttpGet("/logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Register");
        }
    }
}