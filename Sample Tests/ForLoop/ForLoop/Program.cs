using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForLoop
{
    class Program
    {
        static int prod, sum;
        static void Main(string[] args)
        {
            sum = 0;
            prod = 1;

            for (int i=1;i<= 10; i++)
            {
                sum = sum + i;
                prod = prod * i;
            }

            Console.WriteLine(" Sum: " +Convert.ToString(sum));
            Console.WriteLine(" Prod: " +Convert.ToString(prod));
            Console.ReadLine();
        }
    }
}
