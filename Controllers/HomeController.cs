using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ApartmentNetwork.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ApartmentNetwork.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }

        //COMBINED PARTIAL LOGIN/REGISTRATION PAGE
        public IActionResult Index()
        {
            return View("LoginReg");
        }

        //REGISTER NEW USER PAGE//
        // [HttpGet("Register")]
        // public IActionResult Register()
        // {
        //     return View();
        // }

        //REGISTER NEW USER PROCESS//
        [HttpPost("RegisterUser")]
        public IActionResult RegisterUser(User newUser)
        {
            // Check initial ModelState
            if(ModelState.IsValid)
            {
                // If a User exists with provided email
                if(_context.Users.Any(u => u.Email == newUser.Email))
                {
                    // Manually add a ModelState error to the Email field, with provided
                    // error message
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("LoginReg");
                }
                else
                {
                    //add the stuff to the database!
                    // Initializing a PasswordHasher object, providing our User class as its type
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    //Save your user object to the database
                    Console.WriteLine("Success! now you can add me to the database!");
                    _context.Add(newUser);
                    _context.SaveChanges();
                    HttpContext.Session.SetInt32("UserId", newUser.UserId);
                    return RedirectToAction("Dashboard");
                }
            }
            return View("LoginReg");
        }


        //LOGIN USER PAGE//
        // [HttpGet("Login")]
        // public IActionResult Login()
        // {
        //     return View();
        // }

        //LOGIN EXISTING USER PROCESS//
        [HttpPost("LoginUser")]
        public IActionResult LoginUser(LoginUser userSubmission)
        {
            if(ModelState.IsValid)
            {
                // If inital ModelState is valid, query for a user with provided email
                User userInDb = _context.Users
                    .FirstOrDefault(u => u.Email == userSubmission.LoginEmail);
                // If no user exists with provided email
                if(userInDb == null)
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
                    return View("LoginReg");
                }
                
                // Initialize hasher object
                // var hasher = new PasswordHasher<LoginUser>();
                PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
                
                // verify provided password against hash stored in db
                var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.LoginPassword);
                
                // result can be compared to 0 for failure
                if(result == 0)
                {
                    // handle failure (this should be similar to how "existing email" is handled)
                    ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
                    return View("LoginReg");
                }
                Console.WriteLine(userInDb.UserId);
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                Console.WriteLine("Session is "+HttpContext.Session.GetInt32("UserId"));
                return RedirectToAction("Dashboard");
            }
            Console.WriteLine("Model Is Not Valid");
            return View("LoginReg");
        }

        //LOGOUT USER//
        [HttpGet("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            Console.WriteLine("Session has been cleared!");
            return View("LoginReg");
        }


        // DISPLAY DASHBOARD
        [HttpGet("Dashboard")]
            public IActionResult Dashboard()
        {
            //Check if User is logged in
            int? sessionID = HttpContext.Session.GetInt32("UserId");
            Console.WriteLine("UserId is "+ sessionID);
            if (sessionID==null)
            {
                ModelState.AddModelError("LoginPassword", "Please Login First");
                ModelState.AddModelError("FirstName", "Please Register First");
                return View("LoginReg");
            }

            User userInDb = _context.Users
                    // .Include(usr => usr.Attending)
                    .FirstOrDefault(u => u.UserId == sessionID);
            ViewBag.CurrentUser = userInDb;

            // Import data from database
            // ViewBag.AllGroupEvents = _context.GroupEvents
            // .Include(pln => pln.Planner)
            // .Include(gst => gst.Guests)
            // .ThenInclude(usr => usr.User)
            // .OrderBy(evnt => evnt.DateAndTime)
            // .ToList();

            return View();
        }


        // DISPLAY NEW GROUPEVENT PAGE
        // [HttpGet("NewGroupEvent")]
        // public IActionResult NewGroupEvent()
        // {
        //     return View();
        // }


        // CREATE NEW GROUPEVENT PROCESS
        // [HttpPost("NewGroupEvent/process")]
        // public IActionResult NewGroupEventProcess(GroupEvent newGroupEvent)
        // {
        //     //CHECK IF USER IS LOGGED IN
        //     int? sessionID = HttpContext.Session.GetInt32("UserId");
        //     Console.WriteLine("UserId is "+ sessionID);
        //     if (sessionID==null)
        //     {
        //         ModelState.AddModelError("LoginPassword", "Please Login First");
        //         ModelState.AddModelError("FirstName", "Please Register First");
        //         return View("LoginReg");
        //     }
        //     User userInDb = _context.Users
        //             .FirstOrDefault(u => u.UserId == sessionID);
        //     ViewBag.CurrentUser = userInDb;


            // FORM VALIDATION
        //     if (ModelState.IsValid)
        //     {
        //         // CHECK THAT GROUPEVENT DATE IS IN THE FUTURE
        //         if (newGroupEvent.DateAndTime > DateTime.Now)
        //         {
        //             newGroupEvent.UserId = (int)sessionID;//Sets GroupEvent UserId = to logged-in user
        //             _context.Add(newGroupEvent);
        //             _context.SaveChanges();
        //             return RedirectToAction("SingleGroupEvent", new {id = newGroupEvent.GroupEventID});
        //         }
        //         else
        //         {
        //             ModelState.AddModelError("DateAndTime", "You can't have an event in the past!");
        //             return View("NewGroupEvent");
        //         }
        //     }
        //     return View("NewGroupEvent");
        // }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
