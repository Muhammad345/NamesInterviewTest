using CandidateNames.Models;
using ITelentCloudsServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelentCloudsServices;

namespace CandidateNames.Controllers
{
    public class CompanyController : Controller
    {
        public readonly IService<Company> CompanyService;
        
        public CompanyController(IService<Company> companyService)
        {
            CompanyService = companyService;
        }
        
        // GET: 
        public ActionResult Index()
        {
            //return View(CompanyService.GetAll());
            return View();
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Company company)
        {
            return Redirect("index");

            //return View();
        }

        [HttpGet]
        public ActionResult AddBillingAddress(Guid companyId)
        {
            var billingAddress = new BillingDetails
            {
                CompanyId = companyId
            };

            return View(billingAddress);
        }


        [HttpPost]
        public ActionResult AddBillingAddress(BillingDetails billingAddress)
        {
            return Redirect("index");

            //return View();
        }
    }
}