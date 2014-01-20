using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMapper.Models
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string TotalAmountPaid { get; set; }
        public string ShippingAddress { get; set; }
    }
}