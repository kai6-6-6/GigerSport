using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigerSport.Models
{
    public class ChinsesFontList
    {
        public int chineseFontId { get; set; }
        public string chineseFontName { get; set; }
    }

    public class EngilshFontList
    {
        public int engilshFontId { get; set; }
        public string engilshFontName { get; set; }
    }
    public class FontColorList
    {
        public int fontColorId { get; set; }
        public string fontColorName { get; set; }
    }
    public class NumberFontList
    {
        public int numberFontId { get; set; }
        public string numberFontName { get; set; }
    }
    public class StyleList
    {
        public int styleId { get; set; }
        public string styleName { get; set; }
    }
    public class SizeList
    {
        public int sizeId { get; set; }
        public string sizeName { get; set; }
    }
    public class CreateList
    {
        public List<ChinsesFontList> chinsesFontLists { get; set; }
        public List<EngilshFontList> engilshFontLists { get; set; }
        public List<FontColorList> fontColorLists { get; set; }
        public List<NumberFontList> numberFontLists { get; set; }
        public List<StyleList> styleLists { get; set; }
        public List<SizeList> sizeList { get; set; }
    }
}