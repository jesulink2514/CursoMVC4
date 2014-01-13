using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CursoMVC4.Models
{
    public class CustomerViewModel
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public DateTime LastOrderDate { get; set; }
        public bool IsActive { get; set; }
    }
}