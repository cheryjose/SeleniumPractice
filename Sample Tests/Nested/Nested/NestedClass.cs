using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nested
{
    class Outer
    {
        public int x;
        public int y;
        public Outer(int x, int y)
        {
            this.x = x;
            this.y = y;
            
            Console.WriteLine("This is the Outer constructor,"+" x:"+Convert.ToString(x)+" and y:"+Convert.ToString(y));
        }
        public class Inner
        {
            public static string strval1;
            public static string strval2;

            public Inner(string strval1, string strval2)
            {
                Inner.strval1 = strval1;
                Inner.strval2 = strval2;
                Console.WriteLine("This is the Inner constructor");

            }

            public void show()
            {
                Console.WriteLine("The value for strval1: " + strval1 + " The value for strval2: " + strval2);
                
            }

            public class InnerSub
            {

                public InnerSub()
                {

                    Console.WriteLine("this is the InnerSub constructor");
                }

            }
           
        }
        public class Inner1
        {
            public Inner1()
            {
                Console.WriteLine("This is the Inner1 constructor");
            }

        }
    }
}
