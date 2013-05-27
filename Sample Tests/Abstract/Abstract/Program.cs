using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibraryPractice;
namespace Abstract
{
    class Program
    {
        public static int Result;
        static void Main(string[] args)
        {
           
            AbstractDerived obj1 = new AbstractDerived();
            Result= obj1.Calculate(200,300);
            Console.WriteLine(Result);
            Console.ReadLine();
        }
    }
}
