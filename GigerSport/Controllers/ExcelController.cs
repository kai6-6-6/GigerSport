using GigerSport.Services;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
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
            //FormForCustomerService MakeForm = new FormForCustomerService();
            //MakeForm.MakeFormForCustomer();
            string Desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            var file = new FileInfo($@"{Desktop}\Giger Sport訂購單.xlsx");
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
            //ep.SaveAs(file);
            //ep.Dispose();




            MemoryStream fileStream = new MemoryStream();
            ep.SaveAs(fileStream);
            ep.Dispose();
            fileStream.Position = 0;
            return File(fileStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ExportRanger.xlsx");











            //return RedirectToAction("Index", "Home");
        }

        public ActionResult ForFactory(int orderid)
        {
            GetOrderService GetOrderservice = new GetOrderService();
            var OrderDetail = GetOrderservice.UnDoneOrderDetail(orderid);
            FormForFactoryService MakeForm = new FormForFactoryService();
            MakeForm.MakeFormForFactory(OrderDetail);
            return RedirectToAction("UnDoneOrderDetail", "Order", new { orderNumber=OrderDetail.OrderNumber });
        }
        public ActionResult ForQuotation(int orderid)
        {
            GetOrderService GetOrderservice = new GetOrderService();
            var OrderDetail = GetOrderservice.UnDoneOrderDetail(orderid);
            QuotationService MakeForm = new QuotationService();
            MakeForm.MakeFormForCustomer(OrderDetail);
            return RedirectToAction("UnDoneOrderDetail", "Order", new { orderNumber = OrderDetail.OrderNumber });
        }
    }
}