using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IdentifiersExample
{
    class Program
    {
        static int @i, _sum, i_j;
        static void Main(string[] args)
        {
            for(@i=0;@i<=10;@i++)
            {
                _sum=_sum+i;
                Console.WriteLine(Convert.ToString(_sum));
                
            }
            i_j=_sum;
            Console.WriteLine("Value of _sum is: " + Convert.ToString(_sum));
            Console.WriteLine("Value of i_j is: " + Convert.ToString(i_j));
            Console.ReadLine();
        }
    }
}
