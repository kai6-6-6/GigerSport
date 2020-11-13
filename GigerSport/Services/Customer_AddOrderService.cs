using GigerSport.DBModel;
using GigerSport.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigerSport.Services
{
    public class Customer_AddOrderService
    {
        private GigerSportDB context = new GigerSportDB();
        public void ImToUnChexkDB(string Name, string Phone, string Email, string Department, string Major, string Address, string Tex, int Style, string FrontWord, string BackWord, int ChineseFont, int EngilshFont, int NumberFont, int FontColor, int Quantity, string[] PlayerNumber, string[] PlayerName, bool[] LeaderMark, int[] PlayerSize)
        {
            GigerSportRepository<undoneOrder> add_undoneOrder = new GigerSportRepository<undoneOrder>(context);
            GigerSportRepository<undonePlayer> add_undonePlayer = new GigerSportRepository<undonePlayer>(context);
            int MakeorderDetailId;
            try
            {
                MakeorderDetailId = context.undoneOrder.Select((x) => x.undoneOrderId).Max() + 1;
            }
            catch
            {
                MakeorderDetailId = 1;
            }

            undoneOrder order = new undoneOrder()
            {
                undoneOrderId = MakeorderDetailId,
                customerName = Name,
                phone = Phone,
                email = Email,
                department = Department,
                major = Major,
                address = Address,
                texId = Tex,
                styleId = Style,
                frontWord = FrontWord,
                backWord = BackWord,
                chineseFontId = ChineseFont,
                englishFontId = EngilshFont,
                numberFontId = NumberFont,
                fontColorId = FontColor,
                quantity = Quantity
            };
            add_undoneOrder.Create(order);
            int MakePlayerId;
            try
            {
                MakePlayerId = context.undonePlayer.Select((x) => x.playerId).Max() + 1;
            }
            catch
            {
                MakePlayerId = 1;
            }
            if (PlayerName != null)
            {
                for (var i = 0; i < PlayerName.Length; i++)
                {
                    undonePlayer Player = new undonePlayer()
                    {
                        playerId = MakePlayerId + i,
                        playerName = PlayerName[i],
                        number = PlayerNumber[i],
                        leader = LeaderMark[i],
                        undoneorderDetailId = MakeorderDetailId,
                        size = PlayerSize[i]
                    };
                    add_undonePlayer.Create(Player);
                }
            }
            context.SaveChanges();
        }
    }
}