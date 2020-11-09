using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigerSport.Models
{
    public class orderItemModel
    {
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string Customer { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string TexId { get; set; }
        public string Major { get; set; }
        public decimal Amount { get; set; }
        public bool Done { get; set; }
    }
}