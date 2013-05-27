

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
namespace BMICalculatorNameSpace
{
    class ReadingFromExcel
    {
        
        /*Input parameters for ReadExcelValues "FileName - name of the file", "SheetName - name of the file"
        Input parameters for ReadExcelValues "ColumnNumber - array[] input with column numbers"
        Input parameters for  "ColumnNumber - array[] input with column numbers, "Header - specify if column header value is required in the result"
        Return parameter multidimensional string[,] array named - ExcelValueListTemp
         */
        public string[,] ReadExcelValues(string FileName, string SheetName, int[] ColumnNumber, bool Header)
        {
            Excel.Application ExcelApp;
            Excel.Workbook WorkBook;
            Excel.Worksheet WorkSheet;

            ExcelApp = new Excel.Application();
            ExcelApp.Visible = true;
            WorkBook = ExcelApp.Workbooks.Open(FileName);
            WorkSheet = WorkBook.Worksheets[SheetName];
            string[,] ExcelValueListTemp = new string[WorkSheet.UsedRange.Rows.Count, ColumnNumber.Length];
            for (int j = 1; j <= WorkSheet.UsedRange.Columns.Count; j++)
            {
                for (int i = 1; i <= WorkSheet.UsedRange.Rows.Count; i++)
                {
                    for (int z = 0; z < ColumnNumber.Length; z++)
                    {
                        //Consider only the columns specified in the method input "ColumnNumber - array[] input with column numbers"
                        if (j == ColumnNumber[z])
                        {
                            //Flow if method input for Header is true
                            if (Header == true)
                            {
                                string str1 = WorkSheet.Cells[i, ColumnNumber[z]].Value;
                                //Condition to ignore all the null values
                                if (str1 != null)
                                {
                                    //ExcelValueListTemp.Add(ColumnNames[z].ToString() + ";" + str1);
                                    ExcelValueListTemp[i, j] = str1;
                                }
                            }
                            //Flow if method input Header is false
                            else if (Header == false)
                            {
                                if (i > 1)
                                {
                                    string str1 = WorkSheet.Cells[i, ColumnNumber[z]].Value;
                                    //Condition to ignore all the null values
                                    if (str1 != null)
                                    {
                                        ExcelValueListTemp[i - 2, ColumnNumber[z] - 1] = str1;
                                        //Console.WriteLine(ExcelValueListTemp[i - 1, ColumnNames[z] - 1]);
                                        //Console.WriteLine("i-1 :" + (i - 2) + " ColumnNames[z]-1: " + (ColumnNames[z] - 1));
                                    }
                                }
                            }
                        }

                    }
                }

            }
            WorkBook.Save();
            ExcelApp.Quit();
            return ExcelValueListTemp;

        }


         public void WriteExcelValues(string FileName, string SheetName, string ResultStatus, string ResultVal = "Desc", bool InsertToExstCloumn = false)
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
                    if (WorkSheet.Cells[i, lastUsedColumn+1].Value == null)
                    {
                        count = count + 1;
                        Console.WriteLine(count);
                        if (ResultStatus == "Pass")
                        {
                            WorkSheet.Cells[i, lastUsedColumn].Value = "Pass: " + ResultVal;
                            WorkSheet.Cells[i, lastUsedColumn].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGreen);

                        }
                        else if (ResultStatus == "Fail")
                        {
                            WorkSheet.Cells[i, lastUsedColumn].Value = "Fail: " + ResultVal;
                            WorkSheet.Cells[i, lastUsedColumn].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                            //WorkSheet.Cells[count, lastUsedColumn].Color = "Red";
                        }
                        else if (ResultStatus == "Warning")
                        {
                            WorkSheet.Cells[i, lastUsedColumn].Value = "Warning: " + ResultVal;
                            WorkSheet.Cells[i, lastUsedColumn].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                            //WorkSheet.Cells[count, lastUsedColumn].Color = "Red";
                        }
                        else if (ResultStatus == "###")
                        {
                            WorkSheet.Cells[i, lastUsedColumn].Value = " " + " ";
                            //WorkSheet.Cells[count, lastUsedColumn].Color = "Red";
                        }
                    }
                 }
                Console.WriteLine(count);
  
             
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

    