using System;

namespace PracticeClasses
{
    class example1
    {
        static int x;
        static int y;
        static double a;
        static double b;

        static void Main()
        {
            Console.WriteLine("\"This is an example class\"");
            Console.WriteLine("Enter Value for x: ");
            x = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value for y: ");
            y = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Result of x * y : " + Convert.ToString(x*y));
            Console.WriteLine("Enter Value for a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Value for b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(a*b);
            

            Console.ReadLine();
        }

    }

}