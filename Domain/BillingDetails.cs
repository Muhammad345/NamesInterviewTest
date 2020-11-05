using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CandidateNames.Models
{
    public class BillingDetails
    {
        public Guid CompanyId { get; set; }

        public string Address { get; set; }

        public bool AcceptTC { get; set; }
    }
}