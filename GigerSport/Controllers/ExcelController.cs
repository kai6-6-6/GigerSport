using GigerSport.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GigerSport.Controllers
{
    public class ExcelController : Controller
    {
        public ActionResult ForCustomer()
        {
            FormForCustomerService MakeForm = new FormForCustomerService();
            MakeForm.MakeFormForCustomer();
            return RedirectToAction("CreateOrder", "Order");
        }
    }
}