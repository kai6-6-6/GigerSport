using GigerSport.Services;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GigerSport.Controllers
{
    public class ExcelController : Controller
    {
        public ActionResult ForCustomer()
        {
            ExcelPackage ep = new ExcelPackage();
            ExcelWorksheet sheet = ep.Workbook.Worksheets.Add("訂購單");
            sheet.Cells["A1:K1"].Merge = true;
            sheet.Cells["A2:A5"].Merge = true;
            sheet.Cells["A6:A12"].Merge = true;
            sheet.Cells["B2:C2"].Merge = true;
            sheet.Cells["B3:C3"].Merge = true;
            sheet.Cells["B4:C4"].Merge = true;
            sheet.Cells["B5:C5"].Merge = true;
            sheet.Cells["B6:C6"].Merge = true;
            sheet.Cells["B7:C7"].Merge = true;
            sheet.Cells["B8:C8"].Merge = true;
            sheet.Cells["B9:C9"].Merge = true;
            sheet.Cells["B10:C12"].Merge = true;
            sheet.Cells["D2:F2"].Merge = true;
            sheet.Cells["D3:F3"].Merge = true;
            sheet.Cells["D4:F4"].Merge = true;
            sheet.Cells["D5:K5"].Merge = true;
            sheet.Cells["D6:F6"].Merge = true;
            sheet.Cells["D7:F7"].Merge = true;
            sheet.Cells["D8:F8"].Merge = true;
            sheet.Cells["D9:F9"].Merge = true;
            sheet.Cells["D10:k12"].Merge = true;
            sheet.Cells["G2:H2"].Merge = true;
            sheet.Cells["G3:H3"].Merge = true;
            sheet.Cells["G4:H4"].Merge = true;
            sheet.Cells["G6:H6"].Merge = true;
            sheet.Cells["G7:H7"].Merge = true;
            sheet.Cells["G8:H8"].Merge = true;
            sheet.Cells["G9:K9"].Merge = true;
            sheet.Cells["I2:K2"].Merge = true;
            sheet.Cells["I3:K3"].Merge = true;
            sheet.Cells["I4:K4"].Merge = true;
            sheet.Cells["I6:K6"].Merge = true;
            sheet.Cells["I7:K7"].Merge = true;
            sheet.Cells["I8:K8"].Merge = true;
            sheet.Cells["A13:A37"].Merge = true;
            for (var i = 13; i <= 53; i++)
            {
                sheet.Cells[$"C{i}:D{i}"].Merge = true;
                sheet.Cells[$"F{i}:G{i}"].Merge = true;
                sheet.Cells[$"H{i}:I{i}"].Merge = true;
                sheet.Cells[$"J{i}:K{i}"].Merge = true;
            }
            sheet.Cells["A2:K37"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            sheet.Cells["A2:K37"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
            sheet.Cells["A2:K37"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            sheet.Cells["A2:K37"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
            sheet.Cells["A2:K37"].Style.Font.Size = 12;
            sheet.Cells["A2:K37"].Style.Font.Name = "微軟正黑體";
            sheet.Cells["A1:K1"].Style.Font.Size = 22;
            sheet.Cells["A1:K1"].Style.Font.Name = "Arial Black";
            sheet.Cells["A1:K1"].Style.Font.Bold = true;
            sheet.Cells["A1:K37"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells["A1:K37"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            sheet.Row(1).Height = 40;
            for (var i = 2; i <= 37; i++)
            {
                sheet.Row(i).Height = 20;
            }
            sheet.PrinterSettings.FitToWidth = 1;
            sheet.Cells["B2:C12"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet.Cells["B2:C12"].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#FFF2CC"));
            sheet.Cells["G2:H4"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet.Cells["G2:H4"].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#FFF2CC"));
            sheet.Cells["G6:H8"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet.Cells["G6:H8"].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#FFF2CC"));
            sheet.Cells["B13:K13"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet.Cells["B13:K13"].Style.Fill.BackgroundColor.SetColor(System.Drawing.ColorTranslator.FromHtml("#FFF2CC"));
            sheet.Cells["A1:K1"].Value = "JIGERSPORT訂購單-競技服";
            sheet.Cells["A2:A5"].Value = "訂購資訊";
            sheet.Cells["A2:A5"].Style.TextRotation = 255;
            sheet.Cells["A6:A12"].Value = "球衣";
            sheet.Cells["A6:A12"].Style.TextRotation = 255;
            sheet.Cells["B2:C2"].Value = "校名/公司名";
            sheet.Cells["B3:C3"].Value = "科系";
            sheet.Cells["B4:C4"].Value = "訂購人姓名";
            sheet.Cells["B5:C5"].Value = "收件地址";
            sheet.Cells["B6:C6"].Value = "款式";
            sheet.Cells["B7:C7"].Value = "中文字型";
            sheet.Cells["B8:C8"].Value = "英文字型";
            sheet.Cells["B9:C9"].Value = "號碼字型";
            sheet.Cells["B10:C12"].Value = "備註";
            sheet.Cells["G2:H2"].Value = "連絡電話";
            sheet.Cells["G3:H3"].Value = "E-MAIL";
            sheet.Cells["G4:H4"].Value = "統編";
            sheet.Cells["G6:H6"].Value = "正面隊名";
            sheet.Cells["G7:H7"].Value = "背面隊名";
            sheet.Cells["G8:H8"].Value = "字體顏色";
            sheet.Cells["A13"].Value = "球員資訊";
            sheet.Cells["A13"].Style.TextRotation = 255;
            sheet.Cells["B13"].Value = "編號";
            sheet.Cells["C13:D13"].Value = "姓名";
            sheet.Cells["E13"].Value = "號碼";
            sheet.Cells["F13:G13"].Value = "上衣尺寸";
            sheet.Cells["H13:I13"].Value = "褲子尺寸";
            sheet.Cells["J13:K13"].Value = "備註";
            sheet.Cells["J14:K14"].Value = "是否要隊長槓:";
            sheet.Cells["B14"].Value = "隊長/1";
            int j = 2;
            for (var i = 15; i <= 37; i++)
            {
                sheet.Cells[$"B{i}"].Value = j;
                j++;
            }
            sheet.PrinterSettings.PaperSize = ePaperSize.A4;
            sheet.PrinterSettings.Orientation = eOrientation.Portrait;
            sheet.PrinterSettings.HorizontalCentered = true;
            sheet.PrinterSettings.FitToPage = true;
            MemoryStream fileStream = new MemoryStream();
            ep.SaveAs(fileStream);
            ep.Dispose();
            fileStream.Position = 0;
            return File(fileStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Giger Sport訂購單.xlsx");
        }

        public ActionResult ForFactory(int orderid)
        {
            GetOrderService GetOrderservice = new GetOrderService();
            var OrderDetail = GetOrderservice.UnDoneOrderDetail(orderid);
            int PLayersMembers = OrderDetail.Players.Count();
            ExcelPackage ep = new ExcelPackage();
            ExcelWorksheet sheet = ep.Workbook.Worksheets.Add("FirstSheet");
            sheet.Cells["B1:C1"].Merge = true;
            sheet.Cells["E1:F1"].Merge = true;
            sheet.Cells["B2:F2"].Merge = true;
            sheet.Cells[$"A{PLayersMembers + 4}:C{PLayersMembers + 4}"].Merge = true;
            sheet.Cells[$"A1:F{PLayersMembers + 4}"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            sheet.Cells[$"A1:F{PLayersMembers + 4}"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
            sheet.Cells[$"A1:F{PLayersMembers + 4}"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            sheet.Cells[$"A1:F{PLayersMembers + 4}"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
            sheet.Cells[$"A1:F{PLayersMembers + 4}"].Style.Font.Size = 12;
            sheet.Cells[$"A1:F{PLayersMembers + 4}"].Style.Font.Name = "微軟正黑體";
            sheet.Cells["B2:F2"].Style.Font.Color.SetColor(Color.Red);
            sheet.Cells[$"A{PLayersMembers + 4}:C{PLayersMembers + 4}"].Style.Font.Color.SetColor(Color.Red);
            sheet.Cells[$"C{PLayersMembers + 4}"].Style.Font.Color.SetColor(Color.Red);
            sheet.Cells[$"D{PLayersMembers + 4}"].Style.Font.Color.SetColor(Color.Red);
            sheet.Cells[$"E{PLayersMembers + 4}"].Style.Font.Color.SetColor(Color.Red);
            sheet.Cells["B2:F2"].Style.Fill.PatternType = ExcelFillStyle.Solid;
            sheet.Cells["B2:F2"].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
            sheet.Cells[$"A1:F{PLayersMembers + 4}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells[$"A1:F{PLayersMembers + 4}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
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
            sheet.Cells["B1:C1"].Value = OrderDetail.Department.ToString();
            sheet.Cells["D1"].Value = "款式/顏色:";
            sheet.Cells["E1:F1"].Value = OrderDetail.Style.ToString();
            sheet.Cells["B2:F2"].Value = "沒標註就是男版版型，前米通145G反面印刷，後A186，交叉領褲子要口袋";
            sheet.Cells["B3"].Value = "姓名/隊名";
            sheet.Cells["C3"].Value = "號碼";
            sheet.Cells["D3"].Value = "上衣尺寸";
            sheet.Cells["E3"].Value = "褲子尺寸";
            sheet.Cells["F3"].Value = "備註";
            sheet.Cells[$"A{PLayersMembers + 4}:C{PLayersMembers + 4}"].Value = "數量合計";
            sheet.Cells[$"D{PLayersMembers + 4}"].Value = PLayersMembers;
            sheet.Cells[$"E{PLayersMembers + 4}"].Value = PLayersMembers;
            int j = 0;
            for (var i = 4; i <= PLayersMembers + 3; i++)
            {
                sheet.Row(i).Height = 20;
                sheet.Cells[$"A{i}"].Value = (j + 1).ToString();
                sheet.Cells[$"B{i}"].Value = OrderDetail.FrontWord.ToString();
                sheet.Cells[$"C{i}"].Value = OrderDetail.Players[j].number.ToString();
                sheet.Cells[$"D{i}"].Value = OrderDetail.Players[j].size.ToString();
                sheet.Cells[$"E{i}"].Value = OrderDetail.Players[j].size.ToString();
                if (OrderDetail.Players[j].leader == true) { sheet.Cells[$"F{i}"].Value = "隊長標記"; }
                j++;
            }
            MemoryStream fileStream = new MemoryStream();
            ep.SaveAs(fileStream);
            ep.Dispose();
            fileStream.Position = 0;
            return File(fileStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", $"{OrderDetail.Customer}-工廠訂單.xlsx");
        }
    
        public ActionResult ForQuotation(int orderid)
        {
            GetOrderService GetOrderservice = new GetOrderService();
            var OrderDetail = GetOrderservice.UnDoneOrderDetail(orderid);
            int PLayersMembers = OrderDetail.Players.Count();
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
            sheet.Cells[$"A19:D{PLayersMembers+19}"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            sheet.Cells[$"A19:D{PLayersMembers+19}"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
            sheet.Cells[$"A19:D{PLayersMembers+19}"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            sheet.Cells[$"A19:D{PLayersMembers+19}"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
            sheet.Cells["A1:J1"].Style.Font.Size = 36;
            sheet.Cells["A1:J1"].Style.Font.Name = "Bauhaus 93";
            sheet.Cells["A1:J1"].Style.Font.Bold = true;
            sheet.Cells["A2:J2"].Style.Font.Size = 20;
            sheet.Cells["A2:J2"].Style.Font.Name = "標楷體";
            sheet.Cells["A2:J2"].Style.Font.Bold = true;
            sheet.Cells["A3:J17"].Style.Font.Size = 13;
            sheet.Cells["A3:J17"].Style.Font.Name = "標楷體";
            sheet.Cells[$"A19:D{PLayersMembers+19}"].Style.Font.Size = 12;
            sheet.Cells[$"A19:D{PLayersMembers+19}"].Style.Font.Name = "標楷體";
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
            sheet.Cells[$"A19:D{PLayersMembers+19}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            sheet.Cells[$"A19:D{PLayersMembers+19}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
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
            sheet.Cells["A19:D19"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            sheet.Cells["A19:D19"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            sheet.Cells["A1:J1"].Value = "JIGERSPORT";
            sheet.Cells["A2:J2"].Value = "報 價 單";
            sheet.Cells["A3:G3"].Value = $"客戶名稱: {OrderDetail.Customer}";
            sheet.Cells["A4:G4"].Value = $"電話: {OrderDetail.Phone}";
            sheet.Cells["A5:G5"].Value = $"地址: {OrderDetail.Address}";
            sheet.Cells["H3:J3"].Value = $"報價日期:{DateTime.Now.ToString("yyyy/MM/dd")}";
            sheet.Cells["H4:J4"].Value = $"單據編號:{OrderDetail.OrderNumber}";
            sheet.Cells["H5:J5"].Value = $"統一編號:{OrderDetail.TexId}";
            sheet.Cells["A7"].Value = "序號";
            sheet.Cells["A8"].Value = "1";
            sheet.Cells["A9"].Value = "2";
            sheet.Cells["A10"].Value = "3";
            sheet.Cells["A11"].Value = "4";
            sheet.Cells["B7:C7"].Value = "商品名稱";
            sheet.Cells["D7"].Value = "樣式";
            sheet.Cells["D8"].Value = OrderDetail.Style.ToString();
            sheet.Cells["E7"].Value = "數量";
            sheet.Cells["E8"].Value = OrderDetail.Quantity.ToString(); ;
            sheet.Cells["F7"].Value = "單位";
            sheet.Cells["G7"].Value = "單價";
            sheet.Cells["H7:I7"].Value = "金額";
            sheet.Cells["H8:I8"].Value = Math.Round(OrderDetail.Amount, 0).ToString();
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
            for (var i = 1; i <= 10; i++)
            {
                sheet.Column(i).Width = 9.5;
            }
            int j = 0;
            for (var i = 20; i <= OrderDetail.Players.Count() + 19; i++)
            {
                sheet.Cells[$"A{i}"].Value = (j + 1).ToString();
                sheet.Cells[$"B{i}"].Value = OrderDetail.Players[j].playerName.ToString();
                sheet.Cells[$"C{i}"].Value = OrderDetail.Players[j].size.ToString();
                sheet.Cells[$"D{i}"].Value = OrderDetail.Players[j].size.ToString();
                sheet.Row(i).Height = 19;
                sheet.Cells[$"A{i}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                sheet.Cells[$"A{i}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                sheet.Cells[$"B{i}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                sheet.Cells[$"B{i}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                sheet.Cells[$"C{i}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                sheet.Cells[$"C{i}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                sheet.Cells[$"D{i}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                sheet.Cells[$"D{i}"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                j++;
            }
            using (System.Drawing.Image image = System.Drawing.Image.FromFile(HttpContext.Server.MapPath("~/Assets/img/BankInfo.png")))
            {
                var excelImage = sheet.Drawings.AddPicture("BankInfo", image);
                excelImage.SetPosition(12, 8, 6, 0);
            }
            sheet.PrinterSettings.PaperSize = ePaperSize.A4;
            sheet.PrinterSettings.Orientation = eOrientation.Portrait;
            sheet.PrinterSettings.HorizontalCentered = true;
            sheet.PrinterSettings.FitToPage = true;
            MemoryStream fileStream = new MemoryStream();
            ep.SaveAs(fileStream);
            ep.Dispose();
            fileStream.Position = 0;
            return File(fileStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", $"{OrderDetail.Customer}-報價單.xlsx");
        }
    }
}