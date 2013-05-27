//using System;
//using System.Windows.Forms;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using Selenium;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Support.UI;
//using System.Data;
////using Excel=Microsoft.Office.Interop.Excel;
//using Excel = Microsoft.Office.Interop.Excel;

//namespace BusinessCreation
//{
//    class ExcelOperationNewSheet
//    {
       
//        static void Main(string[] args)
//        {
//            //Excel.Application excelApp;
//            //Excel.Workbook workBook;
//            //Excel.Sheets sheet;
//            //Excel.Worksheet workSheet;
//            //Excel.Range sheetRange;
//            //string str;
//            //excelApp = new Excel.Application();
//            //excelApp.Visible = true;
//            //workBook = excelApp.Workbooks.Open(@"C:\Users\chery\Desktop\Openings_AU.xlsx");
//            //workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);
//            //sheetRange = workSheet.UsedRange;
//            //for (int i = 1; i <= workSheet.UsedRange.Rows.Count; i++)
//            //{
//            //    str = (sheetRange.Cells[i, 1] as Excel.Range).Value;
//            //    Console.WriteLine(str);
               
//            //}
//            //Console.ReadLine();
//            Excel.Application ExcelApp;
//            Excel.Workbook WorkBook;
//            Excel.Worksheet sheet1;
//            Excel.Worksheet sheet2;
//            Excel.Range range;
//            ExcelApp = new Excel.Application();
//            ExcelApp.Visible=true;
//            WorkBook = ExcelApp.Workbooks.Open(@"C:\Users\chery\Desktop\Openings_AU.xlsx");
//            // Get sheet by sheet id
//            //sheets = WorkBook.Worksheets.get_Item(2);    
//            // Get sheet by sheet name
//            sheet1 = WorkBook.Worksheets["Sheet1"];
//            sheet2 = WorkBook.Worksheets["Sheet2"];
            
//            for (int j = 1; j <= sheet1.Range["A1:B100"].Columns.Count; j++)
//            {
//              for (int i = 1; i <= sheet1.Range["A1:B100"].Rows.Count; i++)
//              {
//                    if (j == 1 || j==2 && i!=1)
//                    {
//                        string str1 = sheet1.Cells[i, j].Value;
//                        sheet2.Cells[i, 1].Value = str1;
//                        Console.WriteLine(str1);
//                    }
//                    if (i == 1)
//                    {
//                        string str2 = sheet1.Cells[i, j].Value;
//                        Console.WriteLine(str2);
//                    }
//                }

//            }
//            string from = "A1";
//            string to = "B1";
//            Excel.Range range1 = sheet1.get_Range(from, to);
//            //Excel.Range rangeFind = range1.Find("Tester- BI");
//            //Console.WriteLine(rangeFind.);

//            WorkBook.Save();
//            WorkBook.Close();
//            ExcelApp.Quit();
//            Console.ReadLine();
//        }
//    }
//}
