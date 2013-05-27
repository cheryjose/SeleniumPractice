using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace NUnit_Practice
{
    public class Arithmetic
    {
        int Sum, Sub, Div, Mul;
        public int sum(int a, int b)
        {
            Sum = a + b;
            return this.Sum;
        }

        public int sub(int a, int b)
        {
            Sub = a - b;
            return this.Sub;
        }
        public int div(int a, int b)
        {
            Div = a / b;
            return this.Div;
        }
        public int mul(int a, int b)
        {
            Mul = a * b;
            return this.Mul;
        }
        public static void Main(string[] args)
        {
            Arithmetic obj = new Arithmetic();
            Console.WriteLine(obj.mul(5, 6));
            Console.ReadLine();

        }


    }

}
