using CandidateNames.Models;
using ITelentCloudsServices;
using System;
using System.Web.Mvc;

namespace CandidateNames.Controllers
{
    public class CompanyController : Controller
    {
        public readonly IDataService<Company> CompanyDataService;
        public readonly IDataService<UserDetail> UserDataService;
        public readonly IDataService<BillingDetails> BillingDataService;

        public CompanyController(IDataService<Company> companyDataService, IDataService<UserDetail> userDataService, IDataService<BillingDetails> billingDataService)
        {
            CompanyDataService = companyDataService;
            UserDataService = userDataService;
            BillingDataService = billingDataService;
        }
        
        // GET: 
        public ActionResult Index()
        {
            return View(CompanyDataService.GetAll());
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

            if (ModelState.IsValid)
            {

                company.Id = Guid.NewGuid();

                if (CompanyDataService.Insert(company).IsSuccessFull)
                {
                    return Redirect("index");
                }
            }

            return View(company);
        }

        [HttpGet]
        public ActionResult AddBillingAddress(Guid id)
        {
            var billingAddress = new BillingDetails
            {
                CompanyId = id,
                 Address = "Any Address"
            };

            return View(billingAddress);
        }


        [HttpPost]
        public ActionResult AddBillingAddress(BillingDetails billingAddress)
        {

            if (ModelState.IsValid)
            {
                if (BillingDataService.Insert(billingAddress).IsSuccessFull)
                {
                    return RedirectToAction("index", "Company");
                }
            }

            return View(billingAddress);
        }


        [HttpGet]
        public ActionResult AddUserDetail(Guid id)
        {
            var userDetail = new UserDetail
            {
                CompanyId = id,
                Name = "Irfan",
                Email ="IrfanAkhtar345@hotmail.com",
                Password = "Irfan"
            };

            return View(userDetail);
        }


        [HttpPost]
        public ActionResult AddUserDetail(UserDetail userDetail)
        {
            if (ModelState.IsValid)
            {

                if (UserDataService.Insert(userDetail).IsSuccessFull)
                {
                    return RedirectToAction("index", "Company");
                }
            }

            return View(userDetail);
        }
    }
}