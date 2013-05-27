using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace AreaOfCircle
{
    class Program
    {
        static string radius;
        static double area;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle: ");
            radius= Console.ReadLine();
            try
            {
                area = Convert.ToDouble(radius) * Convert.ToDouble(radius) * 3.124;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Area of the circle: "+ Convert.ToString(area));
            Console.ReadLine();
        }
    }
}
