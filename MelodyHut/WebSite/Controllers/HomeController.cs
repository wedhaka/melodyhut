using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult TestRequest() {
            return Json("hi", JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult TestPostRequest()
        {
            return Json("hi");
        }

        [HttpGet]
        public JsonResult TestDataRequest(string name, int id)
        {
            return Json("hi", JsonRequestBehavior.AllowGet);
        }
    }
}
