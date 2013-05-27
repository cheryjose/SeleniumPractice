using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using SeleniumTests;
using Excel = Microsoft.Office.Interop.Excel;

namespace SeleniumTests
{
    class Program
    {


        static void Main(string[] args)
        {
            string[] SearchText;
            SearchText = new string[5];
            SearchText[0] = "Chery Jose";
            SearchText[1] = "Ajith M Jose";
            SearchText[2] = "Maya";
            SearchText[3] = "Tinu";
            SearchText[4] = "Jose Zacharias";

            //Excel.Application xlApp = new Excel.Application();
            //Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"T:/C.xlsx");
            //Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            //Excel.Range xlRange = xlWorksheet.UsedRange;

            //int rowCount = xlRange.Rows.Count;
            //int colCount = xlRange.Columns.Count;
            //Selenium2TestBase Sel2Base = new Selenium2TestBase();
            //Sel2Base.SetupTest();
            //for (int i = 1; i <= rowCount; i++)
            //{
            //    for (int j = 1; j <= colCount; j++)
            //    {
            //        Sel2Base.TheSelenium2TestBaseTest(xlRange.Cells[i, j].Value2.ToString());
            //    }
            //}


            AllSalon sal = new AllSalon();
            sal.SetupTest();
            sal.TheAllSalonTest();
            Console.ReadKey();
            //Sel2Base.TeardownTest();
            //AccountTest AccTest = new AccountTest();
            //AccTest.Init();
            //AccTest.TransferWithInsufficientFundsAtomicity();
           
            //String temp = Console.ReadLine();
            //Account Acc = new Account();
            //Acc.MultiplyOnetoTwen(Convert.ToInt16(temp));
            //String temp1 = Console.ReadLine();
            
        }
    }
}
