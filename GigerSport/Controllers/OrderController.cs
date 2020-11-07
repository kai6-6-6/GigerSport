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


        public ActionResult CreateOrder()
        {

            return View();
        }

        // POST: Banners/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult CreateOrder([Bind(Include = "Banner1,Title,Sut_title,Text,Banner_photo_url,Last_updata_date")] Banner banner)
        //{
        //    if (ModelState.IsValid)
        //    {

        //    }

        //    return View(banner);
        //}



        public ActionResult DoneOrderItems()
        {
            var OrderItem = service.DoneOrderItem();
            return View(OrderItem);
        }

        public ActionResult DoneOrderDetail(int orderNumber)
        {
            var OrderDetail = service.DoneOrderDetail(orderNumber);
            return View(OrderDetail);
        }

        public ActionResult UnDoneOrderItem()
        {
            var OrderItem = service.UnDoneOrderItem();
            return View(OrderItem);
        }

        public ActionResult UnDoneOrderDetail(int orderNumber)
        {
            var OrderDetail = service.UnDoneOrderDetail(orderNumber);
            return View(OrderDetail);
        }



        public ActionResult DeleteItem(int orderNumber)
        {
            order deleteTarget = GigerSportDB.order.Find(orderNumber);
            GigerSportDB.order.Remove(deleteTarget);
            GigerSportDB.SaveChanges();
            return RedirectToAction("DoneOrderItems");
        }

        public ActionResult DeleteDetail(int orderDetailId)
        {
            orderDetail deleteTarget = GigerSportDB.orderDetail.Find(orderDetailId);
            GigerSportDB.orderDetail.Remove(deleteTarget);
            GigerSportDB.SaveChanges();
            return RedirectToAction("DoneOrderDetail");
        }

    }
}
