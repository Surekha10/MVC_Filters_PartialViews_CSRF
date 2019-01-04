using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Filters_PartialView_CSRF.Controllers
{
    [HandleError(View ="Error")]//Exception Filter
    public class HomeController : Controller
    {
        [OutputCache(Duration =30)]//Result Filter
        public ActionResult GetDetails()
        {
            ViewBag.msg = DateTime.Now.ToString();
            return View();
        }
        [HandleError(ExceptionType=typeof(DivideByZeroException),View ="MyError")]
        public ActionResult GetUpdate()
        {
            int x = 100;
            int y = 0;
            int total = x / y;
            return View();
        }
    }
}