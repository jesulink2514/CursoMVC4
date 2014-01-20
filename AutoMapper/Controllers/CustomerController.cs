using AutoMapper.Models;
using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoMapper.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public CustomerController():this(new CustomerRepository())
        {
        }

        //
        // GET: /Customer/
        public ActionResult Index()
        {
            var customers = _customerRepository.GetAll();
            return View(customers);
        }

        //
        // GET: /Customer/Details/5
        public ActionResult Details(int id)
        {
            var customer = _customerRepository.GetById(id);
            var cust= Mapper.Map<CustomerViewModel>(customer);
            return View(cust);
        }
    }
}
