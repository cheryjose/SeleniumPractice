using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string []stringArr = new string[10];
            stringArr[0] = "senthil";
            stringArr[1] = "chery";
            stringArr[2] = "murali";
            stringArr[3] = "amit";
            stringArr[4] = "vinish";
            stringArr.OrderByDescending<>;
            List<string> students = new List<string>();
            Console.WriteLine(students.Count());
            students.Add("senthil");
            students.Add("chery");
            students.Add("murali");
            students.Add("amit");
            students.Add("vinish");
            foreach(string student in students)
            {
                Console.WriteLine(student);
            }
            students.Sort();
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            Console.ReadLine();
        }
    }
}
