using GigerSport.DBModel;
using GigerSport.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace GigerSport.Services
{
    public class OrderInToDBService
    {
        private GigerSportDB context = new GigerSportDB();
        public void InToDB(string Name, string Phone, string Address, string Email, string Tex, string Department, string FrontWord, int FrontWordSize, string BackWord, int BackWordSize, string Major, int Quantity, double Discount, string Img, int ChineseFontWord, int EngilshFontWord, int FontColor, int NumberFontWord, int Style, string[] PlayerNumber, string[] PlayerName, bool[] LeaderMark, int[] PlayerSize)
        {
            GigerSportRepository<customer> Ride_customer = new GigerSportRepository<customer>(context);
            GigerSportRepository<order> Ride_order = new GigerSportRepository<order>(context);
            GigerSportRepository<orderDetail> Ride_orderDetail = new GigerSportRepository<orderDetail>(context);
            GigerSportRepository<player> Ride_player = new GigerSportRepository<player>(context);
            var makeCustomerId = context.customer.Select((x) => x.customerId).Max();
            var makeOrderDetailId = context.orderDetail.Select((x) => x.orderDetailId).Max();
            var FindCustomer = context.customer.FirstOrDefault((x) => x.customerName == Name);
            int newCustomerId;
            if (FindCustomer != null)
            {
                FindCustomer.phone = Phone; FindCustomer.email = Email; FindCustomer.department = Department;
                newCustomerId = makeCustomerId;
                Ride_customer.Update(FindCustomer);
            }
            else
            {
                newCustomerId = makeCustomerId + 1;
                customer AddCustomer = new customer()
                {
                    customerId = makeCustomerId + 1,
                    customerName = Name,
                    phone = Phone,
                    email = Email,
                    department = Department,
                    major = Major
                };
                Ride_customer.Create(AddCustomer);
            }
            var OrderNumber = int.Parse(DateTime.Now.ToString("MMddHHmm"));
            order AddOrder = new order()
            {
                orderNumber = OrderNumber,
                customerId = newCustomerId,
                orderDate = DateTime.Now,
                done = false
            };
            Ride_order.Create(AddOrder);
            bool HasplayerList = false;
            if (PlayerName != null)
            {
                var makePlayerId = context.player.Select((x) => x.playerId).Max();
                HasplayerList = true;
                for (var i = 0; i < PlayerName.Length; i++)
                {
                    player AddPlayer = new player()
                    {
                        playerId = makePlayerId + i + 1,
                        playerName = PlayerName[i],
                        number = PlayerNumber[i],
                        leader = LeaderMark[i],
                        orderDetailId = makeOrderDetailId + 1,
                        size = PlayerSize[i]
                    };
                    Ride_player.Create(AddPlayer);
                }

            }
            if (Discount < 0 || Discount > 1)
            {
                Discount = 1;
            }
            orderDetail AddOrderDetail = new orderDetail()
            {
                orderDetailId = makeOrderDetailId + 1,
                orderNumber = OrderNumber,
                address = Address,
                texId = Tex,
                styleId = Style,
                frontWord = FrontWord,
                frontWordSize = FrontWordSize,
                backWord = BackWord,
                backWordSize = BackWordSize,
                chineseFontId = ChineseFontWord,
                englishFontId = EngilshFontWord,
                numberFontId = NumberFontWord,
                fontColorId = FontColor,
                quantity = Quantity,
                discount = Discount,
                amount = Convert.ToDecimal(context.style.Where((x) => x.styleId == Style).Select((x) => x.price).First() * Quantity * Discount),
                img = Img,
                playerName = HasplayerList
            };
            Ride_orderDetail.Create(AddOrderDetail);
            context.SaveChanges();
        }
    }
}