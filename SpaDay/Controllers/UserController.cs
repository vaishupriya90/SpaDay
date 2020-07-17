using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [Route("/user/add/")]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [Route("/user/add/")]
        public IActionResult SubmitAddUserForm(User newUser,string verify)
        {
            string email = newUser.EmailAddress;
            if (newUser.Password.Equals(verify))
            {
                ViewBag.userName = newUser.UserName;
                return View("Index");
            }
            ViewBag.error = "ERROR: The Passwords should match";
            ViewBag.usrName = newUser.UserName;
            ViewBag.email = newUser.EmailAddress;
            
            return View();
            
        }
    }
}
