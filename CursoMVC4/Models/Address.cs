using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CursoMVC4.Models
{
    public class Address
    {
        [Required]
        public string Line1 { get; set; }
        public string ZipCode { get; set; }
    }
}