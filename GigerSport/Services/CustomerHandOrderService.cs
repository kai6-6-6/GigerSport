using GigerSport.DBModel;
using GigerSport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigerSport.Services
{
    public class CustomerHandOrderService
    {
        private GigerSportDB context = new GigerSportDB();
        public List<CustomerHandOrderModel> CustomerOrderItem()
        {
            var List = (from undoneO in context.undoneOrder
                       select new CustomerHandOrderModel
                       {
                           customerName = undoneO.customerName,
                           quantity = undoneO.quantity,
                           style = context.style.Where((x) => x.styleId == undoneO.styleId).Select((x) => x.styleName).FirstOrDefault(),
                           undoneOrderId= undoneO.undoneOrderId
                       }).ToList();
            return List;
        }
        
        public EditDetaiModel CompleteOrder(int undoneOrderId)
        {
            CreateProductListService GetProductList = new CreateProductListService();
            EditDetaiModel CompleteOrder = new EditDetaiModel();
            CompleteOrder.createList = GetProductList.GetProductList();
            CompleteOrder.detailModel = (from undoneO in context.undoneOrder
                                         where undoneO.undoneOrderId== undoneOrderId
                                         select new DetailModel
                                         {  OrderDetailId= undoneOrderId,
                                             Customer = undoneO.customerName,
                                             Phone= undoneO.phone,
                                             Email= undoneO.email,
                                             Address= undoneO.address,
                                             TexId= undoneO.texId,
                                             Department= undoneO.department,
                                             Major= undoneO.major,
                                             Style= context.style.Where((x)=>x.styleId== undoneO.styleId).Select((x)=>x.styleName).FirstOrDefault(),
                                             StyleId= undoneO.styleId,
                                             FrontWord= undoneO.frontWord,
                                             BackWord= undoneO.backWord,
                                             ChineseFont= context.chineseFont.Where((x)=>x.chineseFontId== undoneO.chineseFontId).Select((x)=>x.chineseFontName).FirstOrDefault(),
                                             ChineseFontId= undoneO.chineseFontId,
                                             EngilshFont=context.engilshFont.Where((x)=>x.engilshFontId== undoneO.chineseFontId).Select((x)=>x.engilshFontName).FirstOrDefault(),
                                             EngilshFontId= undoneO.chineseFontId,
                                             NumberFont=context.numberFont.Where((x)=>x.numberFontId== undoneO.numberFontId).Select((x)=>x.numberFontName).FirstOrDefault(),
                                             NumberFontId= undoneO.numberFontId,
                                             FontColor=context.fontColor.Where((x)=>x.fontColorId== undoneO.fontColorId).Select((x)=>x.fontColorName).FirstOrDefault(),
                                             FontColorId= undoneO.fontColorId,
                                             Quantity= undoneO.quantity,
                                             Players=(from undonrP in context.undonePlayer
                                                      where undonrP.undoneorderDetailId== undoneO.undoneOrderId
                                                      select new playersModel {
                                                          playerName= undonrP.playerName,
                                                          number= undonrP.number,
                                                          leader= undonrP.leader,
                                                          size= context.size.Where((x)=>x.sizeId== undonrP.size).Select((x)=>x.sizeName).FirstOrDefault(),
                                                          sizeId= undonrP.size
                                                      }).ToList()
                                         }).FirstOrDefault();

            return CompleteOrder;
        }
    }
}