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
        private GetOrderService GetOrderservice = new GetOrderService();
        private GigerSportDB GigerSportDB = new GigerSportDB();


        public ActionResult CreateOrder()
        {
            CreateProductList _GetProduct = new CreateProductList();
            var GetProduct = _GetProduct.GetProductList();
            return View(GetProduct);
        }

        [HttpPost]
        public ActionResult CreateOrder(string Name,string Phone,string Address,string Email,string Tex,string Department, string FrontWord, string BackWord, string Major, int Quantity,double? Discount, string Img,int ChineseFontWord,int EngilshFontWord,int FontColor,int NumberFontWord,int Style)
        {
            var receive = Name;
            return View();
        }



        public ActionResult DoneOrderItems()
        {
            var OrderItem = GetOrderservice.DoneOrderItem();
            return View(OrderItem);
        }

        public ActionResult DoneOrderDetail(int orderNumber)
        {
            var OrderDetail = GetOrderservice.DoneOrderDetail(orderNumber);
            return View(OrderDetail);
        }

        public ActionResult UnDoneOrderItem()
        {
            var OrderItem = GetOrderservice.UnDoneOrderItem();
            return View(OrderItem);
        }

        public ActionResult UnDoneOrderDetail(int orderNumber)
        {
            var OrderDetail = GetOrderservice.UnDoneOrderDetail(orderNumber);
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
