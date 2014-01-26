using CursoMVC4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CursoMVC4.Infraestructure
{
    public class CustomerViewModelMapper : ICustomerViewModelMapper
    {
        private MyDbContext _context = new MyDbContext();

        public List<CustomerViewModel> GetAll() 
        {
            return _context.Customers.ToList()
                .Select(c => new CustomerViewModel()
                {
                    FullName = String.Format("{0} {1}", c.FirstName, c.LastName),
                    Address = String.Format("{0} ZIP : {1}", c.Address.Line1, c.Address.ZipCode),
                    IsActive = c.IsActive,
                    LastOrderDate = c.Orders.Any()?c.Orders.OrderByDescending(o => o.OrderDate).First().OrderDate:DateTime.Now
                }).ToList();
        }
    }

    public interface ICustomerViewModelMapper 
    {
        List<CustomerViewModel> GetAll();
    }
}