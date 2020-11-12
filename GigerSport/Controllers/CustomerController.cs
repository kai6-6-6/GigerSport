using GigerSport.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GigerSport.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult NewOrder()
        {
            CreateProductList _GetProduct = new CreateProductList();
            var GetProduct = _GetProduct.GetProductList();
            return View(GetProduct);
        }
        [HttpPost]
        public ActionResult NewOrder(string Name, string Phone, string Address, string Email, string Tex, string Department, string FrontWord, int FrontWordSize, string BackWord, int BackWordSize, string Major, int Quantity,int ChineseFontWord, int EngilshFontWord, int FontColor, int NumberFontWord, int Style, string[] PlayerNumber, string[] PlayerName, bool[] LeaderMark, int[] PlayerSize)
        {
            Customer_AddOrderService uncheck = new Customer_AddOrderService();
            uncheck.ImToUnChexkDB(Name, Phone, Address, Email, Tex, Department, FrontWord, FrontWordSize, BackWord, BackWordSize, Major, Quantity, ChineseFontWord, EngilshFontWord, FontColor, NumberFontWord, Style, PlayerNumber, PlayerName, LeaderMark, PlayerSize);
            return View();
        }
    }
}