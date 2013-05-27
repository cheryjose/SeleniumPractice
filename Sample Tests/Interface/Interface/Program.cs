using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Interface obj1 = new Interface();
            obj1.Calculate1(1,2);
            obj1.Calculate2(1, 2, 3);
            obj1.Calculate3(1, 2, 3, 4);
            obj1.Calculate4(1, 2, 3, 4, 5);
            obj1.IntVal1Local = 1;
            obj1.IntVal2Local = 2;
            obj1.IntVal3Local = 3;
            obj1.IntVal4Local = 4;
            Console.WriteLine("IntVal1 Value: " + Convert.ToString(obj1.IntVal1Local));
            Console.WriteLine("IntVal2 Value: " + Convert.ToString(obj1.IntVal2Local));
            Console.WriteLine("IntVal3 Value: " + Convert.ToString(obj1.IntVal3Local));
            Console.WriteLine("IntVal4 Value: " + Convert.ToString(obj1.IntVal4Local));
            Console.ReadLine();
        }
    }
}
