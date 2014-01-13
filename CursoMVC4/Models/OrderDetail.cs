using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CursoMVC4.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int Count { get; set; }
        public double SubTotal { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}