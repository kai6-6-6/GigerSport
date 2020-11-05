using GigerSport.DBModel;
using GigerSport.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;

namespace GigerSport.Services
{
    public class OrderDetailService
    {
        private GigerSportDB context = new GigerSportDB();
        public List<DetailModel> GetOrderDetail(int orderNumber)
        {
            var List = (from o in context.order
                        join ct in context.customer on o.customer equals ct.customerId
                        join d in context.department on ct.department equals d.departmentId
                        join od in context.orderDetail on o.orderNumber equals od.orderNumber
                        join s in context.style on od.style equals s.styleId
                        join cf in context.chineseFont on od.chineseFont equals cf.chineseFontId
                        join ef in context.engilshFont on od.englishFont equals ef.engilshFontId
                        join nf in context.numberFont on od.numberFont equals nf.numberFontId
                        join fc in context.fontColor on od.fontColor equals fc.fontColorId
                        where o.orderNumber== orderNumber
                        select new DetailModel()
                        {
                            OrderNumber = od.orderNumber,
                            Style = s.style1,
                            FrontWord = od.frontWord,
                            FrontWordSize = od.frontWordSize,
                            BackWord = od.backWord,
                            BackWordSize = od.backWordSize,
                            ChineseFont = cf.chineseFont1,
                            EngilshFont = ef.engilshFont1,
                            NumberFont = nf.numberFont1,
                            FontColor = fc.fontColor1,
                            Quantity = od.quantity,
                            Discount = od.discount,
                            Amount = od.amount,
                            Img = od.img,
                            Players=(from p in context.player
                                     where p.orderDetailId==od.orderDetailId
                                     select new playersModel
                                     {
                                         playerName=p.playerName,
                                         number=p.number,
                                         leader=p.leader,
                                         size=p.size
                                     }).ToList()
                        }).ToList();
            return List;
        }

    }
}