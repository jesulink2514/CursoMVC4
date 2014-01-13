using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AJaxSample.Controllers
{
    [Authorize]
    public class PruebaController : Controller
    {
        private List<string> Comentarios= new List<string>();
        //
        // GET: /Prueba/
        public ActionResult Index()
        {
            return View(Comentarios);
        }

        public ActionResult Politica() 
        {
            if (Request.IsAjaxRequest()) 
            {
                return PartialView();
            }
            return View();
        }

        [HttpPost]
        public ActionResult Comentar(string comentario)
        {
            Comentarios.Add(comentario);
            if (Request.IsAjaxRequest()) 
            {
                return Content("<li>" + comentario + "</li>");
            }
            return RedirectToAction("Index");
        }
	}
}