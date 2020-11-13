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
            CreateProductListService _GetProduct = new CreateProductListService();
            var GetProduct = _GetProduct.GetProductList();
            return View(GetProduct);
        }
        [HttpPost]
        public ActionResult NewOrder(string Name, string Phone, string Email, string Department, string Major, string Address, string Tex, int Style, string FrontWord, string BackWord, int ChineseFont, int EngilshFont, int NumberFont, int FontColor, int Quantity, string[] PlayerNumber, string[] PlayerName, bool[] LeaderMark, int[] PlayerSize)
        {
            Customer_AddOrderService uncheck = new Customer_AddOrderService();
            uncheck.ImToUnChexkDB(Name, Phone, Email, Department, Major, Address, Tex, Style, FrontWord, BackWord, ChineseFont, EngilshFont, NumberFont, FontColor, Quantity, PlayerNumber, PlayerName, LeaderMark, PlayerSize);
            return View();
        }
    }
}