using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nested
{
    class Program
    {
        static void Main(string[] args)
        {
            Outer obj1= new Outer(6,8);
            Outer.Inner obj2 = new Outer.Inner("chery","jose");
            obj2.show();
            Outer.Inner1 obj3 = new Outer.Inner1();
            Outer.Inner.InnerSub obj4 = new Outer.Inner.InnerSub();
            Console.ReadLine();
        }
    }
}
