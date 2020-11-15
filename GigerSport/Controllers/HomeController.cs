using GigerSport.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GigerSport.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult CustomerHandItem()
        {
            CustomerHandOrderService CustomerHand = new CustomerHandOrderService();
            var OrderItem = CustomerHand.CustomerOrderItem();
            return View(OrderItem);
        }
        [Authorize]
        public ActionResult CustomerHandDetail(int undoneOrderId)
        {
            CustomerHandOrderService GetCustoerOrderDetail = new CustomerHandOrderService();
            var GetDetail = GetCustoerOrderDetail.CompleteOrder(undoneOrderId);
            return View(GetDetail);
        }
        [HttpPost]
        public ActionResult CustomerHandDetail(string Name, string Phone, string Address, string Email, string Tex, string Department, string FrontWord, int FrontWordSize, string BackWord, int BackWordSize, string Major, int Quantity, double Discount, string Img, int ChineseFontWord, int EngilshFontWord, int FontColor, int NumberFontWord, int Style, string[] PlayerNumber, string[] PlayerName, bool[] LeaderMark, int[] PlayerSize,int UndoneOrderId)
        {
            OrderInToDBService intoDB = new OrderInToDBService();
            intoDB.InToDB(Name, Phone, Address, Email, Tex, Department, FrontWord, FrontWordSize, BackWord, BackWordSize, Major, Quantity, Discount, Img, ChineseFontWord, EngilshFontWord, FontColor, NumberFontWord, Style, PlayerNumber, PlayerName, LeaderMark, PlayerSize);
            DeleteOrderService Delete = new DeleteOrderService();
            Delete.DeleteUndoneOrder(UndoneOrderId);
            return RedirectToAction("CustomerHandItem");
        }
        [Authorize]
        public ActionResult DeleteCustomerHandOrder(int undoneOrderId)
        {
            DeleteOrderService Delete = new DeleteOrderService();
            Delete.DeleteUndoneOrder(undoneOrderId);
            return RedirectToAction("CustomerHandItem");
        }
        [Authorize]
        public ActionResult System()
        {
            CreateProductListService GetAllList = new CreateProductListService();
            var ProductList=GetAllList.GetProductList();
            return View(ProductList);
        }
        [HttpPost]
        public ActionResult System(string[] chinsesFont,string[] engilshFont,string[] fontColor,string[] numberFont,string[] size,string[] style)
        {
            SaveSystemService Save = new SaveSystemService();
            Save.SaveSystem(chinsesFont, engilshFont, fontColor, numberFont, size, style);
            return RedirectToAction("System");
        }
    }
}