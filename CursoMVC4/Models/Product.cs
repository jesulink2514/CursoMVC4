using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CursoMVC4.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; } 
    }
}