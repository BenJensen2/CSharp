using Microsoft.AspNetCore.Mvc;

namespace HelloASP
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult AboutMe()
        {
            return View();
        }

        // public ViewResult Razor()
        // {
        //     return View();
        // {
        // public ViewResult HiThere()
        // {
        //     // return "This is my Index!";
        //     // Views/Home/HiThere.cshtml
        //     // Views/Shared/HiThere.cshtml
        //     return View();
        //     // return View("Index");
        // }

        [HttpGet("projects")]
        public string Projects()
        {
            return "These are my Projects!";
        }

        [HttpGet("contact")]
        public string Contact()
        {
            return "This is my Contact!";
        }

        [Route("hello")]
        [HttpGet]
        public string Hello()
        {
            return "Hi Again!";
        }
        [HttpGet("users/{username}/{location}")]
        public string HelloUser(string username, string location)
        {
            if(location == "Green Bay")
            {
                return $"Hello {username} from {location}. Go Pack!!";
            }
            return $"Hello {username} from {location}.";
        }
    }
}