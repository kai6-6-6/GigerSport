using GigerSport.DBModel;
using GigerSport.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigerSport.Services
{
    public class DeleteOrderService
    {
        private GigerSportDB context = new GigerSportDB();
        public void DeleteTarget(int orderDetailId)
        {
            GigerSportRepository<order> Del_order = new GigerSportRepository<order>(context);
            GigerSportRepository<orderDetail> Del_orderDetail = new GigerSportRepository<orderDetail>(context);
            GigerSportRepository<player> Del_player = new GigerSportRepository<player>(context);
            var FindOrderDetail = context.orderDetail.Where((x) => x.orderDetailId == orderDetailId).First();
            var FindPlayers = context.player.Where((x) => x.orderDetailId == orderDetailId);
            int FindOrderNumber = context.orderDetail.Where((x) => x.orderDetailId == orderDetailId).Select((x) => x.orderNumber).First();
            var FindOrder = context.order.Where((x) => x.orderNumber == FindOrderNumber).First();
            foreach(var item in FindPlayers)
            {
                Del_player.Delete(item);
            }
            Del_orderDetail.Delete(FindOrderDetail);
            Del_order.Delete(FindOrder);
            context.SaveChanges();
        }
    }
}