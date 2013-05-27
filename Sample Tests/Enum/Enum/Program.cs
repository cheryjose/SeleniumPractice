using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibraryPractice;
namespace Enum
{
    class Program
    {
        public static int Result;
        static void Main(string[] args)
        {
            Enum1 objenum = new Enum1();
            objenum.show();
            AbstractDerived obj1 = new AbstractDerived();
            Result = obj1.Calculate(300, 200);
            Console.WriteLine(Result);
            Console.ReadLine();

        }
    }
}
