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

        public ActionResult ForFactory(int orderid)
        {
            GetOrderService GetOrderservice = new GetOrderService();
            var OrderDetail = GetOrderservice.EditOrderDetail(orderid);
            FormForFactoryService MakeForm = new FormForFactoryService();
            MakeForm.MakeFormForFactory(OrderDetail.detailModel);
            return RedirectToAction("UnDoneOrderDetail", "Order", orderid);
        }
        public ActionResult ForQuotation(int orderid)
        {
            GetOrderService GetOrderservice = new GetOrderService();
            var OrderDetail = GetOrderservice.EditOrderDetail(orderid);
            return View();
        }
    }
}