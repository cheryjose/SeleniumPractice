using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfCondition
{
    class Program
    {
        static int a, b, c;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value for a: ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the value for b:");
            b = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Enter the value for c: ");
            //c = Convert.ToInt16(Console.ReadLine());
            if (a < b)
                Console.WriteLine(" a<b ");
            if (a > b)
                Console.WriteLine(" a>b ");
            if (a == b)
                Console.WriteLine("a==b");
            if (a > b || a == b)
            {
                c = a - b;
                Console.WriteLine(" The value of \"c\" on \"a - b\": "+Convert.ToString(c));

            }
            else if (b > a)
            {
                c = b - a;
                Console.WriteLine(" The value of \"c\" on \"b - a\": "+Convert.ToString(c));
            }

            Console.ReadLine();

        }
    }
}
