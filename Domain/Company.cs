using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CandidateNames.Models
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Industry { get; set; }
        public int Size { get; set; }
    }
}
