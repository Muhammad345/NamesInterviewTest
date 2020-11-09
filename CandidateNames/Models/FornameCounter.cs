using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CandidateNames.Models
{
    public class FornameCounter
    {
        public Dictionary<char, int> nameCharacterCounter { get; set; }

        public string[] Forenames { get; set; }

    }
}