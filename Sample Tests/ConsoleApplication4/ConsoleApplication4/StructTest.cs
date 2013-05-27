using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestNameSpace
{
    class StructTest
    {

    }

    struct point1
    {
        public double x;
        public double y;

        public point1(int x, int y)
        {

            this.x = x;
            this.y = y;
        }
        public string show()
        {
            Console.WriteLine(x + "," + y);
            return x + "," + y;
        }

    }
}
