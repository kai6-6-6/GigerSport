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
        public List<orderItemModel> DoneOrderItem()
        {
            var ListItem = (from o in context.order
                            join ct in context.customer on o.customerId equals ct.customerId
                            where o.done == true
                            select new orderItemModel
                            {
                                OrderNumber=o.orderNumber,
                                OrderDate=o.orderDate,
                                Customer=ct.customerName,
                                Phone=ct.phone,
                                Email=ct.email,
                                TexId=ct.texId,
                                Major=ct.major,
                                Done=o.done,
                                Amount=(from od in context.orderDetail
                                        where od.orderNumber==o.orderNumber
                                        select new {od.amount}).Sum(p=>p.amount)
                            }).ToList();
            return ListItem;
        }

        public List<orderItemModel> UnDoneOrderItem()
        {
            var ListItem = (from o in context.order
                            join ct in context.customer on o.customerId equals ct.customerId
                            where o.done==false
                            select new orderItemModel
                            {
                                OrderNumber = o.orderNumber,
                                OrderDate = o.orderDate,
                                Customer = ct.customerName,
                                Phone = ct.phone,
                                Email = ct.email,
                                TexId = ct.texId,
                                Major = ct.major,
                                Done = o.done,
                                Amount = (from od in context.orderDetail
                                          where od.orderNumber == o.orderNumber
                                          select new { od.amount }).Sum(p => p.amount)
                            }).ToList();
            return ListItem;
        }

        public List<DetailModel> DoneOrderDetail(int orderNumber)
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
                              where o.done == true
                              select new DetailModel
                              {
                                  OrderDetailId=od.orderDetailId,
                                  Customer=ct.customerName,
                                  Phone=ct.phone,
                                  Email=ct.email,
                                  TexId=ct.texId,
                                  Department=ct.department,
                                  Major=ct.major,
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
                                             join s in context.size on p.size equals s.sizeId
                                            where p.orderDetailId==od.orderDetailId
                                            select new playersModel
                                            {
                                                playerName=p.playerName,
                                                number=p.number,
                                                leader=p.leader,
                                                size=s.sizeName
                                            }).ToList()
                              }).ToList();
            return ListDetail;
        }

        public List<DetailModel> UnDoneOrderDetail(int orderNumber)
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
                              where o.done == false
                              select new DetailModel
                              {
                                  OrderDetailId = od.orderDetailId,
                                  Customer = ct.customerName,
                                  Phone = ct.phone,
                                  Email = ct.email,
                                  TexId = ct.texId,
                                  Department = ct.department,
                                  Major = ct.major,
                                  Style = s.styleName,
                                  FrontWord = od.frontWord,
                                  FrontWordSize = od.frontWordSize,
                                  BackWord = od.backWord,
                                  BackWordSize = od.backWordSize,
                                  ChineseFont = cf.chineseFontName,
                                  EngilshFont = ef.engilshFontName,
                                  NumberFont = nf.numberFontName,
                                  FontColor = fc.fontColorName,
                                  Quantity = od.quantity,
                                  Discount = od.discount,
                                  Amount = od.amount,
                                  Img = od.img,
                                  Players = (from p in context.player
                                             join s in context.size on p.size equals s.sizeId
                                             where p.orderDetailId == od.orderDetailId
                                             select new playersModel
                                             {
                                                 playerName = p.playerName,
                                                 number = p.number,
                                                 leader = p.leader,
                                                 size = s.sizeName
                                             }).ToList()
                              }).ToList();
            return ListDetail;
        }

    }
}