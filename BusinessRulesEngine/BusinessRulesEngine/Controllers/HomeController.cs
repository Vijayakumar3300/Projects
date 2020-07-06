using BusinessRulesEngineBL.Interfaces;
using BusinessRulesEngineBL.ObjectServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusinessRulesEngine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection fc)
        {
            string msg = "";
            int orderType = Convert.ToInt16(fc["OrderType"]);
            if (orderType > 0)
            {
                IPaymentDetails obj = PaymentObjectServices.GetPaymentObjectDetails(orderType);
                bool result = obj.Payment(out msg);
            }
            else
                msg = "Please Select an Item For Payment and Submit";

            ViewBag.Message = msg;
            return View();
        }
    }
}