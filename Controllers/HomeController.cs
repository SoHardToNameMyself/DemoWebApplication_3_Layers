using BL_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ClassBL bl = new ClassBL();//consume class "ClassBL" from BL Layer
            var results = bl.GetCustomer_BLL();//get the list from ClassBL class through GetCustomer_BLL function, which initially from ClassDAL class
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Product()
        {
            ViewBag.Message = "Your Product page.";

            return View("ProductPage");
        }
    }
}