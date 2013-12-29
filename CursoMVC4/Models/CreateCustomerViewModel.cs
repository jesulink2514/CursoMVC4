using CursoMVC4.Infraestructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CursoMVC4.Models
{
    public class CreateCustomerViewModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public bool IsActive { get; set; }

        [Required]
        public Address Address { get; set; }

        [ShouldBeTrue(ErrorMessage="You should accept Terms.")]
        public bool AcceptTerms { get; set; }
    }
}