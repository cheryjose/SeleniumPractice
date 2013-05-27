using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WritingToTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            int count=1;
            StreamWriter file = new StreamWriter(@"C:\Users\chery\Desktop\WriteText.txt",true);
            //file.WriteLine("Hi Chery Garu1");
            //file.WriteLine("Ding dong ding");
            file.Close();
            StreamReader file1 = new StreamReader(@"C:\Users\chery\Desktop\WriteText.txt");
            string line = null;
            while ((line = file1.ReadLine()) != null)
            {
                if (line.Contains("ding") || line.Contains("ding"))
                {
                    count = count +1;
                    Console.WriteLine(count);
                }
            }
            //Console.WriteLine(file1.ReadToEnd());
            
            Console.ReadLine();
        }
    }
}
