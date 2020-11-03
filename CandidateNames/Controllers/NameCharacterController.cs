using ITelentCloudsServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TelentCloudsServices;

namespace CandidateNames.Controllers
{
    public class NameCharacterController : Controller
    {
        public readonly ISearchForenameService SearchForenameService;

        public NameCharacterController(ISearchForenameService searchForenameService)
        {
            SearchForenameService = searchForenameService;
        }
        
        // GET: NameCharacter
        public ActionResult Index()
        {
            SearchForenameService.FornameFirstCharacterCount('a');
            return View();
        }
    }
}