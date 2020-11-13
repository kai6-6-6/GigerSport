using GigerSport.DBModel;
using GigerSport.Models;
using GigerSport.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigerSport.Services
{
    public class SaveDetailChangeService
    {
        private GigerSportDB context = new GigerSportDB();
        public void Save(string Name, string Phone, string Address, string Email, string Tex, string Department, string FrontWord, int FrontWordSize, string BackWord, int BackWordSize, string Major, int Quantity, double Discount, string Img, int ChineseFontWord, int EngilshFontWord, int FontColor, int NumberFontWord, int Style, string[] PlayerNumber, string[] PlayerName, bool[] LeaderMark, int[] PlayerSize, int OrderDetailId)
        {
            GigerSportRepository<customer> Change_customer = new GigerSportRepository<customer>(context);
            GigerSportRepository<orderDetail> Change_orderDetail = new GigerSportRepository<orderDetail>(context);
            GigerSportRepository<player> Change_player = new GigerSportRepository<player>(context);
            int GetOrderNumber = context.orderDetail.Where((x) => x.orderDetailId == OrderDetailId).Select((x) => x.orderNumber).First();
            int GetCustomerId = context.order.Where((x) => x.orderNumber == GetOrderNumber).Select((X) => X.customerId).First();
            var FindCustomer = context.customer.Where((x) => x.customerId == GetCustomerId).First();
            FindCustomer.customerName = Name;
            FindCustomer.phone = Phone;
            FindCustomer.email = Email;
            FindCustomer.department = Department;
            FindCustomer.major = Major;
            Change_customer.Update(FindCustomer);

            if (Discount < 0 || Discount > 1)
            {
                Discount = 1;
            }
            var FindOrderDetail = context.orderDetail.Where((x) => x.orderDetailId == OrderDetailId).First();
            var StyleCost = context.style.Where((x) => x.styleId == Style).Select((x) => x.price).First();
            FindOrderDetail.address = Address;
            FindOrderDetail.texId = Tex;
            FindOrderDetail.frontWord = FrontWord;
            FindOrderDetail.frontWordSize = FrontWordSize;
            FindOrderDetail.backWord = BackWord;
            FindOrderDetail.backWordSize = BackWordSize;
            FindOrderDetail.quantity = Quantity;
            FindOrderDetail.discount = Discount;
            FindOrderDetail.img = Img;
            FindOrderDetail.chineseFontId = ChineseFontWord;
            FindOrderDetail.englishFontId = EngilshFontWord;
            FindOrderDetail.fontColorId = FontColor;
            FindOrderDetail.numberFontId = NumberFontWord;
            FindOrderDetail.styleId = Style;
            FindOrderDetail.amount = Convert.ToDecimal(StyleCost * Discount * Quantity);
            Change_orderDetail.Update(FindOrderDetail);

            if (PlayerName != null)
            {
                var GetPlayer = context.player.Where((x) => x.orderDetailId == OrderDetailId);
                foreach (var item in GetPlayer) { Change_player.Delete(item); }
                var makePlayerId = context.player.Select((x) => x.playerId).Max();
                for (var i = 0; i < PlayerName.Length; i++)
                {
                    player AddPlayer = new player()
                    {
                        playerId = makePlayerId + i + 1,
                        playerName = PlayerName[i],
                        number = PlayerNumber[i],
                        leader = LeaderMark[i],
                        orderDetailId = OrderDetailId,
                        size = PlayerSize[i]
                    };
                    Change_player.Create(AddPlayer);
                }
            }
            context.SaveChanges();
        }
    }
}