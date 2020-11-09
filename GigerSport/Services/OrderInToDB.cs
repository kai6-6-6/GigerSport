using GigerSport.DBModel;
using GigerSport.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigerSport.Services
{
    public class OrderInToDB
    {
        private GigerSportDB context = new GigerSportDB();
        public void InToDB(string Name, string Phone, string Address, string Email, string Tex, string Department, string FrontWord, string BackWord, string Major, int Quantity, double Discount, string Img, int ChineseFontWord, int EngilshFontWord, int FontColor, int NumberFontWord, int Style, string[] PlayerNumber, string[] PlayerName, bool[] LeaderMark, int[] PlayerSize)
        {
            GigerSportRepository<customer> Ride_customer = new GigerSportRepository<customer>(context);
            GigerSportRepository<order> Ride_order = new GigerSportRepository<order>(context);
            GigerSportRepository<orderDetail> Ride_orderDetail = new GigerSportRepository<orderDetail>(context);
            GigerSportRepository<player> Ride_player = new GigerSportRepository<player>(context);
            var makeCustomerID = context.customer.Select((x) => x.customerId).Max();
            var FindCustomer = context.customer.FirstOrDefault((x)=>x.customerName== Name);
            if (FindCustomer != null){
                FindCustomer.phone = Phone; FindCustomer.email = Email; FindCustomer.department = Department;
                //Ride_customer.Update(FindCustomer);
                //context.SaveChanges();

            }
            
        }
    }
}