using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFCodeFirst.Models;

namespace EFCodeFirst.Controllers
{
    public class HomeController : Controller
    {

        public PruebaDBContext context =new PruebaDBContext(); 

        public ActionResult Index()
        {
            var schools = context.Schools.Where(s=> s.Name.StartsWith("s")).ToList();
            schools.First().Name = "Nombre x";
            context.SaveChanges();

            return View(schools);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}