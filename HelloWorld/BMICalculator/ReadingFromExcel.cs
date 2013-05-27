

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
        public static string[,] ReadExcelValues(string FileName, string SheetName, int[] ColumnNumber, bool Header)
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
                        if (j == ColumnNames[z])
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

    }
}