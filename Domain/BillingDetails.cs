using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CandidateNames.Models
{
    public class BillingDetails
    {
        [Required(ErrorMessage = "Company Id Required.")]
        public Guid CompanyId { get; set; }

        [DisplayName("Address")]
        public string Address { get; set; }

        [DisplayName("Accept Terms and Conditions")]
        public bool AcceptTC { get; set; }
    }
}