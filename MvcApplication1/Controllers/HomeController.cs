using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.dateshow = DateTime.Now;
            return View();
        }
        [HttpGet]
        public ActionResult elgibility()
        {
            return View();
        }

        [HttpPost]
        public ActionResult elgibility(Eligibile elgibile)
        {
            if (ModelState.IsValid)
            {
                return View("thank You", elgibile);

            }
            else
            {
                return View();
            }



        }

    }
}
