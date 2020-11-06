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

            return null;
        }

        public List<DetailModel> GetOrderDetail(int orderNumber)
        {

            return null;
        }

    }
}