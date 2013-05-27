using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structure
{
    class StructExample
    {

    }

    struct StructExampl1
    {
        public int intval1;
        public int intval2;
        public int intval3;
        public const int intval4=30;
        
        public StructExampl1(int intval1, int intval2)
        {
            this.intval1 = intval1;
            this.intval2 = intval2;
            this.intval3 = 0;
        }

        
        public void show()
        {
            Console.WriteLine("First val: " + Convert.ToString(intval1) + " Second val: " + Convert.ToString(intval2)
                + " Third val: " + Convert.ToString(intval3) + " Fourth val: " + Convert.ToString(intval4));   
            intval1 = 10;
            intval2 = 30;
            Console.WriteLine("First val: " + Convert.ToString(intval1) + " Second val: " + Convert.ToString(intval2)
                + " Third val: " + Convert.ToString(intval3) + " Fourth val: " +Convert.ToString(intval4));   
        }


    }
}
