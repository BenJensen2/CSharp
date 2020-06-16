
using System.Linq;
using BankAccounts.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankAccounts.Controllers
{
    public class BankController : Controller
    {
        private BankContext db;
     
        public BankController(BankContext context)
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

        // public void AssignAccount(User user)
        // {
        //     Account newAccount = new Account(user);
        //     newAccount.Owner = user;
            
        //     db.Accounts.Add(newAccount);
        // }

        [HttpGet("account")]
        public IActionResult Account()
        {
            // (int)uid
            ViewBag.FirstName = HttpContext.Session.GetString("FirstName");
            int? userID = HttpContext.Session.GetInt32("UserId");    
            Account account = db.Accounts.FirstOrDefault(acct => acct.Owner.UserId == userID);
            return View("Account",account);
        }
    }
}