using CursoMVC4.Infraestructure;
using CursoMVC4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoMVC4.Controllers
{
    public partial class CustomersController : Controller
    {
        private readonly ICustomerViewModelMapper mapper;

        public CustomersController(ICustomerViewModelMapper mapper)
        {
            this.mapper = mapper;
        }
        //
        // GET: /Customers/
        public virtual ActionResult Index()
        {
            var customers = mapper.GetAll();
            return View(customers);
        }

        //GET: /Customers/Create
        public virtual ActionResult Create() 
        {
            return View(new CustomerInputViewModel());
        }

        //POST: /Customers/Create
        [HttpPost]
        public virtual ActionResult Create(CustomerInputViewModel customer)
        {
            if (ModelState.IsValid) 
            {
                //agrego a la DB
                return RedirectToAction(MVC.Home.Index());
            }
            return View(customer);
        }
	}
}