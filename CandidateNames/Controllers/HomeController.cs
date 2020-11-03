using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CandidateNames.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // TASK
            // Using the two sources provided in the DAL project and the Source3.txt file located in the sources folder, create a function that counts how many times the first character of the first name appears in both lists ignoring any duplicate names.
            // Display the sum of each character to the browser.
            // Manage and displaying all exceptions in a separate list. Exceptions are names that do not fit with Lastname, Firstname
            // Names can be duplicated and in both lists. Ensure that names are not counted twice.

            // Output similar to:
            // A appears 1 times 
            // B appears 4 times 
            // J appears 6 times


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}