using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigerSport.Models
{
    public class CreateCustomer
    {
        public int customerId { get; set; }
        public string customerName { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string texId { get; set; }
        public int? departmentId { get; set; }
        public string major { get; set; }
    }

    public class CreatModel
    {
        public string chineseFontName { get; set; }
        public string customerName { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string texId { get; set; }
        public string major { get; set; }
        public string departmentName { get; set; }
        public string engilshFontName { get; set; }
        public string fontColorName { get; set; }
    }
}