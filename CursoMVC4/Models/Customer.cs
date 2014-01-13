using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CursoMVC4.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public Address Address { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}