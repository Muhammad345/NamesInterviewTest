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
    public class NameCharacterController : Controller
    {
        public readonly ISearchForenameService SearchForenameService;
        private string[] SampleFornames;
        public NameCharacterController(ISearchForenameService searchForenameService)
        {
            SearchForenameService = searchForenameService;
            SampleFornames = new string[] {
                "Irfan",
                "Andrew",
                "John",
                "King"
            };
        }
        
        // GET: NameCharacter
        public ActionResult Index()
        {
            var fornameCounter = new FornameCounter { nameCharacterCounter = CountFornameSample(), Forenames = SampleFornames };
            return View(fornameCounter);
        }

        private Dictionary<char,int> CountFornameSample()
        {
            var characterCount = new Dictionary<char, int>();
            foreach (var item in SampleFornames)
            {
                var firstCharacterOfForname = item.ToCharArray();
                if(firstCharacterOfForname.Count() > 0 )
                {
                    var character = firstCharacterOfForname[0];
                    var countOccurance = SearchForenameService.FornameFirstCharacterCount(character);
                    if(!characterCount.ContainsKey(character))
                    {
                        characterCount.Add(character, countOccurance);
                    }
                    else
                    {
                        var currentCharacterCount = characterCount[character];
                        characterCount[character] = countOccurance + currentCharacterCount;
                    }
                }
                
            }

            return characterCount;
        }
    }
}