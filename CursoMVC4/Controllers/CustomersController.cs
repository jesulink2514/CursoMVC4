using CursoMVC4.Infraestructure;
using CursoMVC4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoMVC4.Controllers
{
    public class CustomersController : Controller
    {
        private CustomerViewModelMapper mapper = new CustomerViewModelMapper();
        //
        // GET: /Customers/
        public ActionResult Index()
        {
            var customers = mapper.GetAll();
            return View(customers);
        }

        //GET: /Customers/Create
        public ActionResult Create() 
        {
            return View(new CustomerInputViewModel());
        }

        //POST: /Customers/Create
        [HttpPost]
        public ActionResult Create(CustomerInputViewModel customer)
        {
            if (ModelState.IsValid) 
            {
                //agrego a la DB
                return RedirectToAction("Index");
            }
            return View(customer);
        }
	}
}