using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
namespace BusinessCreation
{
    class WritingToExcelSheet
    {
        static void Main(string[] args)
        {
            string FileName = @"C:\Users\chery\Desktop\Openings_AU.xlsx";
            string SheetName = "Sheet2";
            WriteExcelValues(FileName,SheetName,"Warning");
            WriteExcelValues(FileName,SheetName,"Fail","Desc1",true);
            WriteExcelValues(FileName,SheetName,"Pass", "Desc2", true);
            WriteExcelValues(FileName,SheetName,"Warning", "Desc3", true);
            WriteExcelValues(FileName,SheetName,"###", "Desc4", true);
            WriteExcelValues(FileName,SheetName,"Warning", "Desc5", true);
            //WriteExcelValues("Fail2", true);
            //WriteExcelValues("Fail3", true);
            //WriteExcelValues("Fail4", true);
            //Console.ReadLine();
        }

        public static void WriteExcelValues(string FileName, string SheetName, string ResultStatus, string ResultVal = "Desc", bool InsertToExstCloumn = false)
        {
            Excel.Application ExcelApp;
            Excel.Workbook WorkBook;
            Excel.Worksheet WorkSheet;
            ExcelApp = new Excel.Application();
            ExcelApp.Visible= true;
            WorkBook = (Excel.Workbook)ExcelApp.Workbooks.Open(FileName);
            WorkSheet = WorkBook.Worksheets[SheetName];
            WorkSheet.UsedRange.Columns.AutoFit();
            //Finding the last used row and column
            Excel.Range last = WorkSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing);
            Excel.Range range = WorkSheet.get_Range("A1", last);
            int lastUsedRow = last.Row;
            int lastUsedColumn = last.Column;
            if (InsertToExstCloumn == true)
            {
                if (lastUsedColumn == 1 && lastUsedRow==1)
                {
                    WorkSheet.Cells[1, lastUsedColumn].Value = "Result " + 0;
                    WorkSheet.Cells[1, lastUsedColumn].Font.Bold = true;
                    WorkSheet.Cells[1, lastUsedColumn].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
                    WorkSheet.Cells[1, lastUsedColumn].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                }
                int count = 1;
                for (int i = 1; i <= WorkSheet.UsedRange.Rows.Count; i++)
                {
                    if (WorkSheet.Cells[i, lastUsedColumn].Value != null)
                    {
                        count = count + 1;
                        Console.WriteLine(count);
                    }
                 }
                Console.WriteLine(count);
                if (ResultStatus == "Pass")
                {
                    WorkSheet.Cells[count, lastUsedColumn].Value = "Pass: "+ResultVal;
                    WorkSheet.Cells[count, lastUsedColumn].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGreen);
                    
                }
                else if (ResultStatus == "Fail")
                {
                    WorkSheet.Cells[count, lastUsedColumn].Value = "Fail: "+ResultVal;
                    WorkSheet.Cells[count, lastUsedColumn].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                    //WorkSheet.Cells[count, lastUsedColumn].Color = "Red";
                }
                else if (ResultStatus == "Warning")
                {
                    WorkSheet.Cells[count, lastUsedColumn].Value = "Warning: " + ResultVal;
                    WorkSheet.Cells[count, lastUsedColumn].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                    //WorkSheet.Cells[count, lastUsedColumn].Color = "Red";
                }
                else if (ResultStatus == "###")
                {
                    WorkSheet.Cells[count, lastUsedColumn].Value = " " + " ";
                    //WorkSheet.Cells[count, lastUsedColumn].Color = "Red";
                }
                
            }
            else
            {
                
                WorkSheet.Cells[1, lastUsedColumn + 1].Value = "Result " + (lastUsedColumn);
                WorkSheet.Cells[1, lastUsedColumn + 1].Font.Bold=true;
                WorkSheet.Cells[1, lastUsedColumn + 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
                WorkSheet.Cells[1, lastUsedColumn + 1].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                if (ResultStatus == "Pass")
                {
                    WorkSheet.Cells[2, lastUsedColumn + 1].Value = "Pass: " + ResultVal;
                    WorkSheet.Cells[2, lastUsedColumn + 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGreen);
                }
                else if (ResultStatus == "Fail")
                {
                    WorkSheet.Cells[2, lastUsedColumn + 1].Value = "Fail: " + ResultVal;
                    WorkSheet.Cells[2, lastUsedColumn + 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                }
                else if (ResultStatus == "Warning")
                {
                    WorkSheet.Cells[2, lastUsedColumn + 1].Value = "Warning: " + ResultVal;
                    WorkSheet.Cells[2, lastUsedColumn + 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                }
                else if (ResultStatus == "###")
                {
                    WorkSheet.Cells[2, lastUsedColumn + 1].Value = " " + " ";
                    //WorkSheet.Cells[count, lastUsedColumn].Color = "Red";
                }
                
            }
            WorkBook.Save();
            WorkBook.Close();
            ExcelApp.Quit();
        }
    }
}
