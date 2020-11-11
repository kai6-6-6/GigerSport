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
        public ActionResult DeleteDetail(int orderDetailId)
        {
            DeleteOrder deleteOrder = new DeleteOrder();
            deleteOrder.DeleteTarget(orderDetailId);
            return View();
        }
    }
}
