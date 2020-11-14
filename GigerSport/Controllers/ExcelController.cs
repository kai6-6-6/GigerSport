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
            var OrderDetail = GetOrderservice.UnDoneOrderDetail(orderid);
            FormForFactoryService MakeForm = new FormForFactoryService();
            MakeForm.MakeFormForFactory(OrderDetail);
            return RedirectToAction("UnDoneOrderDetail", "Order", new { orderNumber=OrderDetail.OrderNumber });
        }
        public ActionResult ForQuotation(int orderid)
        {
            GetOrderService GetOrderservice = new GetOrderService();
            var OrderDetail = GetOrderservice.UnDoneOrderDetail(orderid);
            QuotationService MakeForm = new QuotationService();
            MakeForm.MakeFormForCustomer(OrderDetail);
            return RedirectToAction("UnDoneOrderDetail", "Order", new { orderNumber = OrderDetail.OrderNumber });
        }
    }
}