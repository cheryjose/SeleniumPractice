using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            StructExampl1 obj = new StructExampl1(101, 202);
            obj.show();
            StructExampl1 obj1 = new StructExampl1();
            obj1.show();
            Console.ReadLine();
        }
    }
}
