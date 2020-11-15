using GigerSport.DBModel;
using GigerSport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace GigerSport.Services
{
    public class CreateProductListService
    {
        private GigerSportDB context = new GigerSportDB();
        private CreateList ProductList = new CreateList();
        public CreateList GetProductList()
        {
            var ChineseList = (from cf in context.chineseFont
                               select new ChinsesFontList
                               {
                                   chineseFontId = cf.chineseFontId,
                                   chineseFontName = cf.chineseFontName
                               }).ToList();
            var EngilshList = (from ef in context.engilshFont
                               select new EngilshFontList
                               {
                                   engilshFontId = ef.engilshFontId,
                                   engilshFontName = ef.engilshFontName
                               }).ToList();
            var FontColorList = (from fc in context.fontColor
                                 select new FontColorList
                                 {
                                     fontColorId = fc.fontColorId,
                                     fontColorName = fc.fontColorName
                                 }).ToList();
            var NumberList = (from nf in context.numberFont
                              select new NumberFontList
                              {
                                  numberFontId = nf.numberFontId,
                                  numberFontName = nf.numberFontName
                              }).ToList();
            var StyleList = (from s in context.style
                             select new StyleList
                             {
                                 styleId = s.styleId,
                                 styleName = s.styleName,
                                 price=s.price
                             }).ToList();
            var SizeList = (from size in context.size
                            select new SizeList
                            {
                                sizeId = size.sizeId,
                                sizeName = size.sizeName
                            }).ToList();
            ProductList.chinsesFontLists = ChineseList;
            ProductList.engilshFontLists = EngilshList;
            ProductList.fontColorLists = FontColorList;
            ProductList.numberFontLists = NumberList;
            ProductList.styleLists = StyleList;
            ProductList.sizeList = SizeList;
            return ProductList;
        }
    }
}