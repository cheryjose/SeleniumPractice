using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enum
{
    class Enum1
    {
        enum EnumTest
        {
            Bysize,
            Byname,
            Bydate,
            Bytype,
            Bystyle=100
        }

        public void show()
        {
            EnumTest EnumTest1;

            int i1 = (int)EnumTest.Bysize;
            int i2 = (int)EnumTest.Byname;
            int i3 = (int)EnumTest.Bydate;
            int i4 = (int)EnumTest.Bytype;
            int i5 = (int)EnumTest.Bystyle;
            Console.WriteLine(" Bysize: " + Convert.ToString(EnumTest.Bysize) +" / Actual value: "+ i1);
            Console.WriteLine(" Byname: " + Convert.ToString(EnumTest.Byname) +" / Actual value: "+ i2);
            Console.WriteLine(" Bydate: " + Convert.ToString(EnumTest.Bydate) +" / Actual value: "+ i3);
            Console.WriteLine(" Bytype: " + Convert.ToString(EnumTest.Bytype) +" / Actual value: "+ i4);
            Console.WriteLine(" Bytype: " + Convert.ToString(EnumTest.Bystyle) + "/ Actual value:"+ i5);
        }
    }

    
}
