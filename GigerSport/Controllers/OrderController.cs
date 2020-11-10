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
        public ActionResult CreateOrder(string Name,string Phone,string Address,string Email,string Tex,string Department, string FrontWord,int FrontWordSize, string BackWord,int BackWordSize, string Major, int Quantity,double Discount, string Img,int ChineseFontWord,int EngilshFontWord,int FontColor,int NumberFontWord,int Style, string[] PlayerNumber,string[] PlayerName,bool[] LeaderMark,int[] PlayerSize)
        {
            OrderInToDB intoDB = new OrderInToDB();
            intoDB.InToDB(Name, Phone, Address, Email, Tex, Department, FrontWord, FrontWordSize, BackWord, BackWordSize, Major, Quantity, Discount, Img, ChineseFontWord, EngilshFontWord, FontColor, NumberFontWord, Style, PlayerNumber, PlayerName, LeaderMark, PlayerSize);


            return RedirectToAction("UnDoneOrderItem");
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
            order deleteOrder = GigerSportDB.order.Find(orderNumber);
            orderDetail deleteOrderDetail = GigerSportDB.orderDetail.Find(orderNumber);
            var GetorderDetailId = GigerSportDB.orderDetail.Where((x) => x.orderNumber == orderNumber).Select((x) => x.orderDetailId).First();
            player deletePlayer = GigerSportDB.player.Find(GetorderDetailId);
            GigerSportDB.order.Remove(deleteOrder);
            GigerSportDB.orderDetail.Remove(deleteOrderDetail);
            GigerSportDB.player.Remove(deletePlayer);
            GigerSportDB.SaveChanges();
            return RedirectToAction("DoneOrderItems");
        }

        public ActionResult DeleteDetail(int orderDetailId)
        {
            orderDetail deleteTarget = GigerSportDB.orderDetail.Find(orderDetailId);
            player deletePlayer = GigerSportDB.player.Find(orderDetailId);
            var GetorderNumber = GigerSportDB.orderDetail.Where((x) => x.orderDetailId == orderDetailId).Select((x) => x.orderNumber).First();
            order deleteOrder = GigerSportDB.order.Find(GetorderNumber);
            GigerSportDB.order.Remove(deleteOrder);
            GigerSportDB.orderDetail.Remove(deleteTarget);
            GigerSportDB.player.Remove(deletePlayer);
            GigerSportDB.SaveChanges();
            return RedirectToAction("DoneOrderDetail");
        }

    }
}
