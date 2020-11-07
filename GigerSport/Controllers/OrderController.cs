using GigerSport.DBModel;
using GigerSport.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GigerSport.Controllers
{
    public class OrderController : Controller
    {
        private GetOrderService service = new GetOrderService();
        private GigerSportDB GigerSportDB = new GigerSportDB();
        public ActionResult OrderItems()
        {
            var OrderItem = service.GetOrderItem();
            return View(OrderItem);
        }

        public ActionResult OrderDetail(int orderNumber)
        {
            var OrderDetail = service.GetOrderDetail(orderNumber);
            return View(OrderDetail);
        }


        public ActionResult DeleteItem(int orderNumber)
        {
            order deleteTarget = GigerSportDB.order.Find(orderNumber);
            GigerSportDB.order.Remove(deleteTarget);
            GigerSportDB.SaveChanges();
            return RedirectToAction("OrderItems");
        }

        public ActionResult DeleteDetail(int orderDetailId)
        {
            orderDetail deleteTarget = GigerSportDB.orderDetail.Find(orderDetailId);
            GigerSportDB.orderDetail.Remove(deleteTarget);
            GigerSportDB.SaveChanges();
            return RedirectToAction("OrderDetail");
        }

        //[HttpPost]
        //public ActionResult OrderDetail([Bind(Include = ("Name,Email,Phone,Address,Birthday,Mobile,Gender"))] Account_List_ViewModel account_detail)
        //{
        //    if (TempData["ID"] != null)
        //    {
        //        var user_name = HttpContext.User.Identity.Name;
        //        var viewmodel = Account.get_account_detail(user_name);
        //        var _order = Account.Get_order(viewmodel.Cust_id);
        //        var _Coupon = Account.Coupon(viewmodel.Cust_id);
        //        ViewBag.Order = _order;
        //        account_detail.Discount = _Coupon.Discount;
        //        account_detail.Cust_id = Convert.ToInt32(TempData["ID"]);
        //        var service = new AccountDetailService();
        //        service.Update(account_detail);
        //    }
        //    int ID = Convert.ToInt32(TempData["ID"]);
        //    return View(account_detail);
        //}
    }
}
