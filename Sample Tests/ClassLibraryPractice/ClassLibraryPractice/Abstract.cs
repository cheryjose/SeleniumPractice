using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryPractice
{
    public abstract class AbstractTest
    {
        protected int IntTest1;
        protected int IntTest2;

        public int IntTest1Val
        {

            get { return IntTest1; }
            set { this.IntTest1 = 20; }
        }

        public int IntTest2Val
        {
            get { return IntTest2; }
            set { this.IntTest2 = 30; }
        }


        public abstract int Calculate(int x, int y); 
    }

    public class AbstractDerived : AbstractTest
    {

        public override int Calculate(int x, int y)
        {

            IntTest1 = x;
            IntTest2 = y;
            Console.WriteLine("Result of Calculation: " + Convert.ToString(IntTest1 * IntTest2));
            return IntTest1 * IntTest2;
        }


    }
}
