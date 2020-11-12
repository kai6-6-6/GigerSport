using GigerSport.DBModel;
using GigerSport.Models;
using GigerSport.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigerSport.Services
{
    public class SaveSystemService
    {
        private GigerSportDB context = new GigerSportDB();
        public void SaveSystem(string[] chinsesFont, string[] engilshFont, string[] fontColor, string[] numberFont, string[] size, string[] style)
        {
            GigerSportRepository<chineseFont> add_chineseFont = new GigerSportRepository<chineseFont>(context);
            GigerSportRepository<engilshFont> add_engilshFont = new GigerSportRepository<engilshFont>(context);
            GigerSportRepository<fontColor> add_fontColor = new GigerSportRepository<fontColor>(context);
            GigerSportRepository<numberFont> add_numberFont = new GigerSportRepository<numberFont>(context);
            GigerSportRepository<size> add_size = new GigerSportRepository<size>(context);
            GigerSportRepository<style> ad_style = new GigerSportRepository<style>(context);
            int MakeChinsesFontId = context.chineseFont.Select((x) => x.chineseFontId).Max() + 1;
            int MakeEngilshFontId = context.engilshFont.Select((x) => x.engilshFontId).Max() + 1;
            int MakeFontColorId = context.fontColor.Select((x) => x.fontColorId).Max() + 1;
            int MakeNumberFontId = context.numberFont.Select((x) => x.numberFontId).Max() + 1;
            int MakeSizeId = context.size.Select((x) => x.sizeId).Max() + 1;
            int MakeStyleId = context.style.Select((x) => x.styleId).Max() + 1;
            if (chinsesFont != null) {
            for(var i =0;i< chinsesFont.Length; i++)
            {
                chineseFont cfList = new chineseFont()
                {
                    chineseFontId = MakeChinsesFontId+i,
                    chineseFontName= chinsesFont[i]
                };
                add_chineseFont.Create(cfList);
            } }
            if (engilshFont != null) {
            for(var i=0;i< engilshFont.Length; i++)
            {
                engilshFont efList = new engilshFont()
                {
                    engilshFontId= MakeEngilshFontId+i,
                    engilshFontName= engilshFont[i]
                };
                add_engilshFont.Create(efList);
            } }
            if (fontColor != null) {
            for (var i = 0; i < fontColor.Length; i++)
            {
                fontColor fcList = new fontColor()
                {
                    fontColorId= MakeFontColorId+i,
                    fontColorName= fontColor[i]
                };
                add_fontColor.Create(fcList);
            } }
            if (numberFont != null) {
            for (var i = 0; i < numberFont.Length; i++)
            {
                numberFont nfList = new numberFont()
                {
                    numberFontId= MakeNumberFontId+i,
                    numberFontName= numberFont[i]
                };
                add_numberFont.Create(nfList);
            } }
            if (size != null) {
            for (var i = 0; i < size.Length; i++)
            {
                size sList = new size()
                {
                    sizeId = MakeSizeId + i,
                    sizeName= size[i]
                };
                add_size.Create(sList);
            } }
            if (style != null) {
            for (var i = 0; i < style.Length; i++)
            {
                style stList = new style()
                {
                    styleId= MakeStyleId+i,
                    styleName= style[i]
                };
                ad_style.Create(stList);
            } }
            context.SaveChanges();
        }
    }
}