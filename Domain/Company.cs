using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CandidateNames.Models
{
    public class Company
    {
        [Required(ErrorMessage ="Company Id Required.")]
        public Guid Id { get; set; }

        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Industry")]
        public string Industry { get; set; }

        [Required]
        [DisplayName("Size")]
        public int Size { get; set; }
    }
}
