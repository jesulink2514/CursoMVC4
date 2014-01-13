using CursoMVC4.Infraestructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CursoMVC4.Models
{
    public class CustomerInputViewModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public Address Address { get; set; }
        
        [ShouldBeTrue(ErrorMessage="You should accept terms.")]
        public bool AcceptTerms { get; set; }
    }
}