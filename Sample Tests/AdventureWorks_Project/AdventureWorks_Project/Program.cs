using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace AdventureWorks_Project
{
    class Dimensions
    {
        public const double PI = Math.PI;
        public double x, y;
        public double Area;

        public Dimensions(double a, double b)
        {
            this.x = a;
            this.y = b;
        }
        public virtual void area()
        {
            Area = x * y;
        }
        public virtual void area2(int a, int b)
        {
            Area = x * y;
        }
    }

    class Circle : Dimensions
    {
        public double x, y, Area;
        public const double PI= Math.PI;
        public Circle(double a, double b):base(2,5)
        {
            this.x = a;
            this.y = b;
        }
        public override void area()
        {
            Area = x * y * PI;
            Console.WriteLine(Area);
            Console.ReadLine();
        }
    }
    class Sphere : Dimensions
    {
        public double Area;
        public const double PI = Math.PI;
        public Sphere(): base(2, 5)
        {
            
        }
        public override void area2(int a, int b)
        {
            Area = a * b * PI;
            Console.WriteLine(Area);
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sphere cobj = new Sphere();
           
            Type objtype = cobj.GetType();
            Console.WriteLine(objtype.Name);
            MethodInfo objInfo = objtype.GetMethod("area2");
            object[] mParam = new object[] {2,5};
            objInfo.Invoke(cobj, mParam);
            Console.WriteLine(objtype.GetMethods());
            cobj.area2(2,5);
        }
    }
}
