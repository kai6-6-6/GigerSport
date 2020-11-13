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
                           style = context.style.Where((x) => x.styleId == undoneO.styleId).Select((x) => x.styleName).First()
                       }).ToList();
            return List;
        }
        public DetailModel 
    }
}