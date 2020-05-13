using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CONTROL_INVENTARIO.Controllers
{
    [Authorize]
    public class PrincipalController : Controller
    {
        // GET: Principal
        public ActionResult Index()
        {
            return View();
        }

    }
}