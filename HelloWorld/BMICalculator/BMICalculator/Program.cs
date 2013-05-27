using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;



namespace BMICalculatorNameSpace
{
    class BMICalculator
    {
        static string[,] ExcelValList;
        static int[] ColumnNames = new int[2];
        static void Main(string[] args)
        {
            double height, weight, resultBMI;
            string heightStr, weightStr, resultBMIStr;
            string FileName = @"C:\Users\chery\Desktop\BMIInput.xlsx";
            string SheetName= "Sheet1";
            string SheetName1 = "Sheet1";
            ColumnNames[0]= 1;
            ColumnNames[1]= 2;
            FirefoxDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www0.health.nsw.gov.au/publichealth/healthpromotion/obesity/bmi.asp");
            ReadingFromExcel excelObj = new ReadingFromExcel();
            ExcelValList = excelObj.ReadExcelValues(FileName, SheetName, ColumnNames, false);
            for (int i = 0; i < ExcelValList.GetLength(0); i++)
            {
                //for (int j = 0; j < ExcelValList.GetLength(1); j++)
                //{
                    //if (ExcelValList[i, j] != null)
                    //{

                        //Console.WriteLine(ExcelValList[i, j]);
                        //Console.WriteLine("i :" + i + " j :" + j);
                    //}
                    //Console.WriteLine("i :" + (i) + " j: " + (j));
                //}
                if (ExcelValList[i, 0] != null && ExcelValList[i, 1] != null)
                {
                    heightStr = Convert.ToString(ExcelValList[i, 0]);
                    weightStr = Convert.ToString(ExcelValList[i, 1]);
                    height = Convert.ToDouble(heightStr);
                    weight = Convert.ToDouble(weightStr);
                    Console.WriteLine("weightStr : " + weightStr);
                    Console.WriteLine("heightStr : " + heightStr);
                    driver.FindElement(By.Name("meters2")).Click();
                    driver.FindElement(By.Name("meters2")).SendKeys(heightStr);
                    driver.FindElement(By.Name("weight2")).Click();
                    driver.FindElement(By.Name("weight2")).SendKeys(weightStr);
                    driver.FindElement(By.XPath("//input[@value='Calculate']")).Click();
                    resultBMIStr = driver.FindElement(By.XPath("//div[@id='bmi_result_number']")).Text;
                    Console.WriteLine("Result from Webpage " + resultBMIStr);
                    resultBMI = Math.Round(weight / (height * height), 2);
                    if (resultBMI == Convert.ToDouble(resultBMIStr))
                    {
                        Console.WriteLine("Calculated BMI equal to Displayed BMI");
                    }
                    else
                    {
                        Console.WriteLine("Calculated BMI not equal to Displayed BMI");
                    }

                    if (resultBMI <= 18.5)
                    {
                        if (driver.FindElement(By.XPath("//tr[@id='class_underweight']")).GetAttribute("style") == "background-color: bisque;")
                        {
                            Console.WriteLine("BMI value is displayed correctly as Underweight in Website in bisque color");
                            excelObj.WriteExcelValues(FileName, SheetName1, "Pass", "bisque", true);
                        }
                        else
                        {
                            Console.WriteLine("BMI value is not correctly displayed as Underweight in Website, and color is wrong");
                        }
                    }
                    else if (resultBMI >= 18.5 && resultBMI <= 24.99)
                    {
                        if (driver.FindElement(By.XPath("//tr[@id='class_normal']")).GetAttribute("style") == "background-color: greenyellow;")
                        {
                            Console.WriteLine("BMI value is correctly displayed as Healthy in Website in Green color");
                            excelObj.WriteExcelValues(FileName, SheetName1, "Pass", "Green", true);
                        }
                        else
                        {
                            Console.WriteLine("BMI value is not correctly displayed as Healthy in Website, and color is wrong");
                        }
                    }
                    else if (resultBMI >= 25.00 && resultBMI <= 29.99)
                    {
                        if (driver.FindElement(By.XPath("//tr[@id='class_overweight']")).GetAttribute("style") == "background-color: gold;")
                        {
                            Console.WriteLine("BMI value is correctly displayed as Overweight in Website in Gold color");
                            excelObj.WriteExcelValues(FileName, SheetName1, "Pass", "Gold", true);
                        }
                        else
                        {
                            Console.WriteLine("BMI value is not correctly displayed as Overweight in Website, and color is wrong");
                        }

                    }
                    else if (resultBMI >= 30)
                    {
                        if (driver.FindElement(By.XPath("//tr[@id='class_obese_class1']")).GetAttribute("style") == "background-color: orangered;")
                        {
                            Console.WriteLine("BMI value is correctly displayed as Obese in Website in Orange color");
                            excelObj.WriteExcelValues(FileName, SheetName1, "Pass", "Orange", true);
                        }
                        else
                        {
                            Console.WriteLine("BMI value is not correctly displayed as Obese in Website, and color is wrong");
                        }
                    }

                    Console.WriteLine("Result calculated " + Convert.ToString(resultBMI));
                }
            }
       
            Console.ReadLine();
        }
    }
}
