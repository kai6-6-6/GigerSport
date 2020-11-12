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
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

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