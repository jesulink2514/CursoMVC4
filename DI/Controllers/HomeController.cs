using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DI.Infraestructure;

namespace DI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMessageProvider _messageProvider;

        public HomeController(IMessageProvider messageProvider)
        {
            if (messageProvider == null) throw new ArgumentNullException("messageProvider");
            _messageProvider = messageProvider;
        }

        public ActionResult Index()
        {
            ViewBag.Message = _messageProvider.GetMessage();
            return View();
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