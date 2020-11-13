using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigerSport.Models
{
    public class CustomerHandOrderModel
    {
        public string customerName { get; set;}
        public int quantity { get; set; }
        public string style { get; set; }
        public int undoneOrderId { get; set; }
    }
}