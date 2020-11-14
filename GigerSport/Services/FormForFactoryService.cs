using GigerSport.Models;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace GigerSport.Services
{
    public class FormForFactoryService
    {
        public void MakeFormForFactory(DetailModel detail)
        {
            int PLayersMembers = detail.Players.Count();
            string Desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            var file = new FileInfo($@"{Desktop}\{detail.Customer}-工廠訂單.xlsx");
            ExcelPackage ep = new ExcelPackage();
            ExcelWorksheet sheet = ep.Workbook.Worksheets.Add("FirstSheet");
            sheet.Cells["B1:C1"].Merge = true;
            sheet.Cells["E1:F1"].Merge = true;
            sheet.Cells["B2:F2"].Merge = true;
            sheet.Cells[$"A{PLayersMembers+4}:C{PLayersMembers+4}"].Merge = true;
            sheet.Cells[$"A1:F{PLayersMembers+4}"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            sheet.Cells[$"A1:F{PLayersMembers+4}"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
            sheet.Cells[$"A1:F{PLayersMembers+4}"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            sheet.Cells[$"A1:F{PLayersMembers+4}"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
            sheet.Cells[$"A1:F{PLayersMembers+4}"].Style.Font.Size = 12;
            sheet.Cells[$"A1:F{PLayersMembers+4}"].Style.Font.Name = "微軟正黑體";
            sheet.Cells["B2:F2"].Style.Font.Color.SetColor(Color.Red);
            sheet.Cells[$"A{PLayersMembers+4}:C{PLayersMembers + 4}"].Style.Font.Color.SetColor(Color.Red);
            sheet.Cells[$"C{PLayersMembers + 4}"].Style.Font.Color.SetColor(Color.Red);
            sheet.Cells[$"D{PLayersMembers + 4}"].Style.Font.Color.SetColor(Color.Red);
            sheet.Cells[$"E{PLayersMembers + 4}"].Style.Font.Color.SetColor(Color.Red);
            sheet.Cells["B2:F2"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet.Cells["B2:F2"].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
            sheet.Cells[$"A1:F{PLayersMembers+4}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells[$"A1:F{PLayersMembers+4}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            sheet.Row(1).Height = 34;
            sheet.Row(2).Height = 34;
            sheet.Row(3).Height = 30;
            sheet.Column(1).Width = 10.5;
            sheet.Column(2).Width = 22.5;
            sheet.Column(3).Width = 12;
            sheet.Column(4).Width = 13.9;
            sheet.Column(5).Width = 13.5;
            sheet.Column(6).Width = 23;
            sheet.Cells["A1"].Value = "姓名/隊名:";
            sheet.Cells["A2"].Value = "備註";
            sheet.Cells["A3"].Value = "編號";
            sheet.Cells["B1:C1"].Value = detail.Department;
            sheet.Cells["D1"].Value = "款式/顏色:";
            sheet.Cells["E1:F1"].Value = detail.Style;
            sheet.Cells["B2:F2"].Value = "沒標註就是男版版型，前米通145G反面印刷，後A186，交叉領褲子要口袋";
            sheet.Cells["B3"].Value = "姓名/隊名";
            sheet.Cells["C3"].Value = "號碼";
            sheet.Cells["D3"].Value = "上衣尺寸";
            sheet.Cells["E3"].Value = "褲子尺寸";
            sheet.Cells["F3"].Value = "備註";
            sheet.Cells[$"A{PLayersMembers+4}:C{PLayersMembers + 4}"].Value = "數量合計";
            sheet.Cells[$"D{PLayersMembers + 4}"].Value = PLayersMembers;
            sheet.Cells[$"E{PLayersMembers + 4}"].Value = PLayersMembers;
            int j = 0;
            for(var i=4;i<= PLayersMembers + 4; i++)
            {
                sheet.Cells[$"A{i}"].Value = j+1;
                sheet.Cells[$"B{i}"].Value = detail.FrontWord;
                sheet.Cells[$"C{i}"].Value = detail.Players[j].number;
                sheet.Cells[$"D{i}"].Value = detail.Players[j].size;
                sheet.Cells[$"E{i}"].Value = detail.Players[j].size;
                if (detail.Players[j].leader == true) { sheet.Cells[$"F{i}"].Value = "隊長標記"; }
                j++;
            }
            ep.SaveAs(file);
            ep.Dispose();
        }
    }
}