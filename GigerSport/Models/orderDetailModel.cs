using GigerSport.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigerSport.Models
{
    public class playersModel
    {
        public string playerName { get; set; }
        public string number { get; set; }
        public bool? leader { get; set; }
        public string size { get; set; }
    }
    public class DetailModel
    {
        public int OrderDetailId { get; set; }
        public string Customer { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string TexId { get; set; }
        public string Style { get; set; }
        public string FrontWord { get; set; }
        public int? FrontWordSize { get; set; }
        public string BackWord { get; set; }
        public int? BackWordSize { get; set; }
        public string ChineseFont { get; set; }
        public string EngilshFont { get; set; }
        public string NumberFont { get; set; }
        public string FontColor { get; set; }
        public int Quantity { get; set; }
        public double? Discount { get; set; }
        public decimal Amount { get; set; }
        public string Img { get; set; }
        public bool PlayerName { get; set; }
        public List<playersModel> Players { get; set; }
    }
}