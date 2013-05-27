using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public delegate string EventHandler(string input);
namespace TestNameSpace
{
    class Program
    {
        public static event EventHandler _show;
        public static string TemString;
        static void Main(string[] args)
        {
            point1 pt=new point1(5,8);
            pt.show();
            Console.ReadLine();
        }
    }

}
    

