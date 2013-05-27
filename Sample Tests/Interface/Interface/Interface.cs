using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{

    interface ITestInterface
    {

        int IntVal1
        {
            get;
            set;
        }

        int IntVal2
        {
            get;
            set;
        }
        int IntVal3
        {
            get;
            set;
        }
        int IntVal4
        {
            get;
            set;
        }
        int Calculate1(int x, int y);
        int Calculate2(int a, int b, int c);
        int Calculate3(int a, int b, int c, int d);
        int Calculate4(int a, int b, int c, int d, int e);
     }
    
    class Interface : ITestInterface
    {
        public int IntVal1Local;
        public int IntVal2Local;
        public int IntVal3Local;
        public int IntVal4Local;

        public int IntVal1
        {
            get { return IntVal1Local; }
            set { IntVal1Local = 1; }
        }
        public int IntVal2
        {
            get { return IntVal2Local; }
            set { IntVal2Local = 2; }
        }
        public int IntVal3
        {
            get { return IntVal3Local; }
            set { IntVal3Local = 3;  }
        }
        public int IntVal4
        {
            get { return IntVal4Local; }
            set { IntVal4Local = 4; }
        }

        public int Calculate1(int a, int b)
        {
            Console.WriteLine("Calculate1- Result: " + Convert.ToString(a*b));
            return a * b;
        }
        public int Calculate2(int a, int b, int c)
        {
            Console.WriteLine("Calculate2- Result: " + Convert.ToString(a * b * c));
            return a * b * c;
        }
        public int Calculate3(int a, int b, int c, int d)
        {
            Console.WriteLine("Calculate3- Result: " + Convert.ToString(a * b * c * d));
            return a * b * c * d;
        }
        public int Calculate4(int a, int b, int c, int d, int e)
        {
            Console.WriteLine("Calculate4- Result: " + Convert.ToString(a * b * c * d * e));
            return(a * b * c * d * e);
        }

    }
}
