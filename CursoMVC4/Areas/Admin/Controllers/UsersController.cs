using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoMVC4.Areas.Admin.Controllers
{
    public partial class UsersController : Controller
    {
        //
        // GET: /Admin/Users/
        public virtual ActionResult Index()
        {
            return View();
        }
	}
}