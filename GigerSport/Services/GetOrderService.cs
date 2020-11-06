using GigerSport.DBModel;
using GigerSport.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;

namespace GigerSport.Services
{
    public class GetOrderService
    {
        private GigerSportDB context = new GigerSportDB();
        public List<orderItemModel> GetOrderItem()
        {
            var ListItem = (from o in context.order
                            join ct in context.customer on o.customerId equals ct.customerId
                            join d in context.department on ct.departmentId equals d.departmentId
                            select new orderItemModel
                            {
                                OrderNumber=o.orderNumber,
                                OrderDate=o.orderDate,
                                Customer=ct.customerName,
                                Phone=ct.phone,
                                Email=ct.email,
                                TexId=ct.texId,
                                Major=ct.major,
                                Department=d.departmentName,
                                Done=o.done,
                                Amount=(from od in context.orderDetail
                                        where od.orderNumber==o.orderNumber
                                        select new {od.amount}).Sum(p=>p.amount)
                            }).ToList();
            return ListItem;
        }

        public List<DetailModel> GetOrderDetail(int orderNumber)
        {
            var ListDetail = (from o in context.order
                              join od in context.orderDetail on o.orderNumber equals od.orderNumber
                              join ct in context.customer on o.customerId equals ct.customerId
                              join s in context.style on od.styleId equals s.styleId
                              join cf in context.chineseFont on od.chineseFontId equals cf.chineseFontId
                              join ef in context.engilshFont on od.englishFontId equals ef.engilshFontId
                              join nf in context.numberFont on od.numberFontId equals nf.numberFontId
                              join fc in context.fontColor on od.fontColorId equals fc.fontColorId
                              where od.orderNumber == orderNumber
                              select new DetailModel
                              {
                                  Customer=ct.customerName,
                                  Phone=ct.phone,
                                  Email=ct.email,
                                  TexId=ct.texId,
                                  Style=s.styleName,
                                  FrontWord=od.frontWord,
                                  FrontWordSize=od.frontWordSize,
                                  BackWord=od.backWord,
                                  BackWordSize=od.backWordSize,
                                  ChineseFont=cf.chineseFontName,
                                  EngilshFont=ef.engilshFontName,
                                  NumberFont=nf.numberFontName,
                                  FontColor=fc.fontColorName,
                                  Quantity=od.quantity,
                                  Discount=od.discount,
                                  Amount=od.amount,
                                  Img=od.img,
                                  Players = (from p in context.player
                                            where p.orderDetailId==od.orderDetailId
                                            select new playersModel
                                            {
                                                playerName=p.playerName,
                                                number=p.number,
                                                leader=p.leader,
                                                size=p.size
                                            }).ToList()
                              }).ToList();
            return null;
        }

    }
}