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
            return View(CompanyService.GetAll());
        }


        [HttpGet]
        public ActionResult Create()
        {
            var company = new Company { Name ="ETZ", Industry ="Software development",Size = 200};
            return View(company);
        }


        [HttpPost]
        public ActionResult Create(Company company)
        {
            company.Id = Guid.NewGuid();

            if (CompanyService.Insert(company).IsSuccessFull)
            {
                return Redirect("index");
            }

            return View(company);
        }

        [HttpGet]
        public ActionResult AddBillingAddress(Guid id)
        {
            var billingAddress = new BillingDetails
            {
                CompanyId = id
            };

            return View(billingAddress);
        }


        [HttpPost]
        public ActionResult AddBillingAddress(BillingDetails billingAddress)
        {
            return RedirectToAction("index", "Company");
        }


        [HttpGet]
        public ActionResult AddUserDetail(Guid id)
        {
            var userDetail = new UserDetail
            {
                CompanyId = id
            };

            return View(userDetail);
        }


        [HttpPost]
        public ActionResult AddUserDetail(UserDetail userDetail)
        {
            return RedirectToAction("index", "Company");
        }
    }
}