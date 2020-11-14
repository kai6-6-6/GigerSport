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
    public class QuotationService
    {
        public void MakeFormForCustomer(DetailModel detail)
        {
            int PLayersMembers = detail.Players.Count();
            string Desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            var file = new FileInfo($@"{Desktop}\{detail.Customer}-報價單.xlsx");
            ExcelPackage ep = new ExcelPackage();
            ExcelWorksheet sheet = ep.Workbook.Worksheets.Add("FirstSheet");
            sheet.Cells["A1:J1"].Merge = true;
            sheet.Cells["A2:J2"].Merge = true;
            sheet.Cells["A3:G3"].Merge = true;
            sheet.Cells["A3:G3"].Merge = true;
            sheet.Cells["A4:G4"].Merge = true;
            sheet.Cells["A5:G5"].Merge = true;
            sheet.Cells["H3:J3"].Merge = true;
            sheet.Cells["H4:J4"].Merge = true;
            sheet.Cells["H5:J5"].Merge = true;
            sheet.Cells["A6:J6"].Merge = true;
            sheet.Cells["B7:C7"].Merge = true;
            sheet.Cells["B8:C8"].Merge = true;
            sheet.Cells["B9:C9"].Merge = true;
            sheet.Cells["B10:C10"].Merge = true;
            sheet.Cells["B11:C11"].Merge = true;
            sheet.Cells["H7:I7"].Merge = true;
            sheet.Cells["H8:I8"].Merge = true;
            sheet.Cells["H9:I9"].Merge = true;
            sheet.Cells["H10:I10"].Merge = true;
            sheet.Cells["H11:I11"].Merge = true;
            sheet.Cells["A12:G12"].Merge = true;
            sheet.Cells["H12:I12"].Merge = true;
            sheet.Cells["A13:J13"].Merge = true;
            sheet.Cells["A14:J14"].Merge = true;
            sheet.Cells["A15:J15"].Merge = true;
            sheet.Cells["A16:J16"].Merge = true;
            sheet.Cells["A17:F17"].Merge = true;
            sheet.Cells["G17:H17"].Merge = true;
            sheet.Cells["A7:J12"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            sheet.Cells["A7:J12"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
            sheet.Cells["A7:J12"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            sheet.Cells["A7:J12"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
            sheet.Cells["A13:J16"].Style.Border.BorderAround(ExcelBorderStyle.Thin);
            sheet.Cells["A19:D39"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            sheet.Cells["A19:D39"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
            sheet.Cells["A19:D39"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            sheet.Cells["A19:D39"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
            sheet.Cells["A1:J1"].Style.Font.Size = 36;
            sheet.Cells["A1:J1"].Style.Font.Name = "Bauhaus 93";
            sheet.Cells["A1:J1"].Style.Font.Bold = true;
            sheet.Cells["A2:J2"].Style.Font.Size = 20;
            sheet.Cells["A2:J2"].Style.Font.Name = "標楷體";
            sheet.Cells["A2:J2"].Style.Font.Bold = true;
            sheet.Cells["A3:J17"].Style.Font.Size = 13;
            sheet.Cells["A3:J17"].Style.Font.Name = "標楷體";
            sheet.Cells["A19:D39"].Style.Font.Size = 12;
            sheet.Cells["A19:D39"].Style.Font.Name = "標楷體";
            sheet.Cells["A1:J1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells["A1:J1"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            sheet.Cells["A2:J2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells["A2:J2"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            sheet.Cells["A3:J5"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            sheet.Cells["A3:J5"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            sheet.Cells["A7:J12"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells["A7:J12"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            sheet.Cells["A13:J17"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            sheet.Cells["A13:J17"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            sheet.Cells["A19:D39"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            sheet.Cells["A19:D39"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            sheet.Row(1).Height = 40.5;
            sheet.Row(2).Height = 30;
            for (var i = 3; i <= 11; i++) { sheet.Row(i).Height = 20; }
            sheet.Row(6).Height = 7.5;
            sheet.Row(12).Height = 30;
            sheet.Row(13).Height = 24.7;
            sheet.Row(14).Height = 24.7;
            sheet.Row(15).Height = 24.7;
            sheet.Row(16).Height = 24.7;
            sheet.Row(17).Height = 40;
            sheet.Row(18).Height = 6;
            sheet.Row(19).Height = 19;
            sheet.Cells["A1:J1"].Value = "JIGERSPORT";
            sheet.Cells["A2:J2"].Value = "報 價 單";
            sheet.Cells["A3:G3"].Value = $"客戶名稱: {detail.Customer}";
            sheet.Cells["A4:G4"].Value = $"電話: {detail.Phone}";
            sheet.Cells["A5:G5"].Value = $"地址: {detail.Address}";
            sheet.Cells["H3:J3"].Value = $"報價日期:{DateTime.Now.ToString("yyyy/MM/dd")}";
            sheet.Cells["H4:J4"].Value = $"單據編號:{detail.OrderNumber}";
            sheet.Cells["H5:J5"].Value = $"統一編號:{detail.TexId}";
            sheet.Cells["A7"].Value = "序號";
            sheet.Cells["A8"].Value = "1";
            sheet.Cells["A9"].Value = "2";
            sheet.Cells["A10"].Value = "3";
            sheet.Cells["A11"].Value = "4";
            sheet.Cells["B7:C7"].Value = "商品名稱";
            sheet.Cells["D7"].Value = "樣式";
            sheet.Cells["D8"].Value = detail.Style.ToString();
            sheet.Cells["E7"].Value = "數量";
            sheet.Cells["E8"].Value = detail.Quantity.ToString(); ;
            sheet.Cells["F7"].Value = "單位";
            sheet.Cells["G7"].Value = "單價";
            sheet.Cells["H7:I7"].Value = "金額";
            sheet.Cells["H8:I8"].Value = Math.Round(detail.Amount,0).ToString();
            sheet.Cells["J7"].Value = "備註";
            sheet.Cells["A12:G12"].Value = "總計";
            sheet.Cells["A13:J13"].Value = "1.本報價單14日內有效";
            sheet.Cells["A14:J14"].Value = "2.製作前需預收50%訂金";
            sheet.Cells["A15:J15"].Value = "3.出貨前通知付款，確認收款後寄出";
            sheet.Cells["A16:J16"].Value = "4.若確認無誤，請於客戶簽名處簽名後回傳，視同合約";
            sheet.Cells["A17:F17"].Value = "聯絡電話: 0975-739633 陳先生";
            sheet.Cells["G17:H17"].Value = "客戶簽名";
            sheet.Cells["A19"].Value = "號碼";
            sheet.Cells["B19"].Value = "姓名";
            sheet.Cells["C19"].Value = "上衣尺寸";
            sheet.Cells["D19"].Value = "褲子尺寸";
            sheet.Cells["D8:D11"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            for(var i = 1; i <= 10; i++)
            {
                sheet.Column(i).Width = 9;
            }
            int j = 0;
            for (var i = 20; i <= detail.Players.Count() + 6; i++)
            {
                sheet.Cells[$"A{i}"].Value = (j + 1).ToString();
                sheet.Cells[$"B{i}"].Value = detail.Players[j].playerName.ToString();
                sheet.Cells[$"C{i}"].Value = detail.Players[j].size.ToString();
                sheet.Cells[$"D{i}"].Value = detail.Players[j].size.ToString();
                sheet.Row(i).Height = 19;
                j++;
            }
            using (System.Drawing.Image image = System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/Assets/img/BankInfo.png")))
            {
                var excelImage = sheet.Drawings.AddPicture("BankInfo", image);

                //add the image to row 20, column E
                excelImage.SetPosition(12, 10, 6, 0);
            }






            sheet.PrinterSettings.PaperSize = ePaperSize.A4;
            sheet.PrinterSettings.Orientation = eOrientation.Portrait;
            sheet.PrinterSettings.HorizontalCentered = true;
            sheet.PrinterSettings.FitToPage = true;
            ep.SaveAs(file);
            ep.Dispose();
        }
    }
}