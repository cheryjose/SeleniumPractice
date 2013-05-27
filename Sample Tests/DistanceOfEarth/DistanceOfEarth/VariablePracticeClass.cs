using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VariableTypePractice
{

    class Practice
    {
        
        
    }

    public class VariablePracticeClass
    {
        public bool a,b;
        public long longDistToInch;
        public const long intDistInMile = 93020000;
        public byte x;
        public int sum,sum1;
        public double radius;
        public double area;
        internal double theta;
        public decimal TotalAmount;
        public decimal DiscountPercentage;
        public decimal Principal;
        public decimal Interest;
        public int years;
        public char ch;
        public string strngText;
        public void DistanceToEarthLong()
        {
            Console.WriteLine("Distance from Earth to Sun in Miles = " + "93,020,000");
            longDistToInch = intDistInMile*12 * 5280;
            Console.WriteLine("Distance from Earth to Sun in Inches = " + Convert.ToString(longDistToInch)+ " inches");
            Console.ReadLine();
        }

        public void BytePractice()
        {
            for (x = 0; x <= 100; x++)
                sum = sum + x;
            Console.WriteLine("Byte value sum :" + Convert.ToString(sum));
            Console.ReadLine();
        }
        public void FloatRadiusOfCircle()
        {
            Console.WriteLine("Enter the Area of the Circle :");
            area = Convert.ToDouble(Console.ReadLine());
            radius = Math.Sqrt(area / 3.14);
            Console.WriteLine("Radius of the circle is : " + Convert.ToString(radius));
            Console.ReadLine();
        }

        internal void TrignometericFrmRadian()
        {
            for (theta = 0.1; theta <= 1.0; theta= theta + 0.1)
            {
                Console.WriteLine("Theta value " + "\" " + Convert.ToString(theta) + " \"");
                Console.WriteLine(" Sine of " + "\" " + Convert.ToString(theta) + " \"" + " = " + Convert.ToString(Math.Sin(theta)));
                Console.WriteLine(" Cos of " + "\" " + Convert.ToString(theta) + " \"" + " = " + Convert.ToString(Math.Cos(theta)));
                Console.WriteLine(" Tan of " + "\" " + Convert.ToString(theta) + " \"" + " = " + Convert.ToString(Math.Tan(theta)));
                
            }
            Console.ReadLine();

        }

        public void DecimalTypeDiscountLogic()
        {
            Console.WriteLine("Enter the Total Amount :");
            TotalAmount=Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ente the Discount percentage :");
            DiscountPercentage=Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Discounted Price : " + (TotalAmount - (TotalAmount * (DiscountPercentage / 100))));
            Console.ReadLine();
        }

        public void DecimalTypeCompoundInterest()
        {
            Console.WriteLine("Enter the Principal Amount: ");
            Principal=Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the No.of years: ");
            years= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Interest rate: ");
            Interest=Convert.ToDecimal(Console.ReadLine());
            for (int i = 1; i <= years; i++)
            {
                Principal = Principal + (Principal * (Interest / 100));
            }

            Console.WriteLine("For Principa "+Principal+" The Amount on Maturity for " + years + " years at Interest rate of " + Interest + " is " + Principal);
            Console.ReadLine();
        }

        public void CharTypePractice()
        {
            int[] chArr= new int[12];
            for (int i = 0; i <12; i++)
            {
                sum1 = sum1 + i;
                chArr[i] = sum1;
                //Console.WriteLine("chArr value for the index " + i + " is " + chArr[i]);
            }
            Console.WriteLine("chArr[11] -1 = "+(chArr[11]-1) + "Char value is "+Convert.ToChar(chArr[11]-1));
            Console.WriteLine("chArr[11] +2 = " + (chArr[11] + 2) + "Char value is " + Convert.ToChar(chArr[11] + 2));
            Console.WriteLine("chArr[11] +17 = " + (chArr[11] + 17) + "Char value is " + Convert.ToChar(chArr[11] + 16));
            Console.WriteLine("Concatenated string is : " + Convert.ToChar(chArr[11] + 16) + Convert.ToChar(chArr[11] -1) + Convert.ToChar(chArr[11] + 2) 
            + Convert.ToChar(chArr[11] - 1) + Convert.ToChar(chArr[11] + 16));
            //Console.WriteLine("Sum is : " + sum1);
            ch = Convert.ToChar("A");
            //Console.WriteLine("Char of ch : " + ch);
            //Console.WriteLine("Int of ch : " + Convert.ToInt16(ch));
            Console.ReadLine();
        }

        public void boolType()
        {
            a = true;
            b = false;

            if (a)
                Console.WriteLine(" 'a' is true");
            else
                Console.WriteLine(" 'a' is false");

            if(b)
                Console.WriteLine(" 'b' is true");
            else 
                Console.WriteLine(" 'b' is false");

            Console.WriteLine("10 > 9  is " + (10 > 9)+" and "+ "9 > 10 is "+(9>10));
            Console.ReadLine();
        }

        public void outputOptions()
        {
            Console.WriteLine("You ordered "+2+" items at $"+3+" each");
            Console.WriteLine("Result of 10/3 = " + 10.0 / 3.0);
            Console.WriteLine("February has {0} or {1} days", 28, 29);
            Console.WriteLine("February has {0,10} or {1,5} days", 28, 29);
            Console.WriteLine("Value\tSquare\tCube");
            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine("{0}\t{1}\t{2}", i, (i * i), (i * i * i));
            }
            Console.WriteLine("Value for 10/3 is {0:#.##}", 10.0 / 3.0);
            Console.WriteLine("Formatted number {0:##,###.###}",12345.56789994);
            Console.WriteLine("The current balance is {0:C}", 15566.9945);
            Console.ReadLine();
        }

        public void escapeSequences()
        {
            Console.WriteLine("\t\tHi Dear Friends\n\t\t!!!!Welcome to the party!!!!");
            Console.WriteLine("\b\aNo Problem\b");
            years = 0xaf;
            Console.WriteLine("Value for 0xaf in Hexa in decimal is " + years);
            Console.WriteLine(@"Here is some tabbed wonderful output
            Name            Age              Job
            ---------------------------------------------------
            Chery           18               Engineer
            Jose            20               Master
            Venu            21               Welder
            ----------------------------------------------------
            ");
            Console.ReadLine();
        }

        public void HypotofTriangle()
        {
            double s1;
            s1=5000;
            double s2=6000;
            double Hypo= Math.Sqrt((s1*s1)+(s1*s2));
            Console.WriteLine("Hypotenuse of a Triangle: {0:#.#}", Hypo);
            Console.Read();
        }

        public void ImplicitlyTypeVariable()
        {
            var e = 1234.5666;
            var e1 = 1234.5666F;
            Console.WriteLine("Value of 'e' is {0}", e);
            Console.WriteLine("Value of 'e1' is {0:#.##}", e1);
            var s1 = 4.0;
            var s2 = 5.0;
            var hypo = Math.Sqrt((s1 * s1) + (s2 * s2));
            s1 = 5.678f;
            s1 = 5;
            //s1 = 5m;
            Console.WriteLine("Hypotenuse value hypo is {0}", hypo);
            Console.WriteLine("Value of s1 is {0}", s1);
            Console.ReadLine();
        }

        public void scopeVariable()
        {
            int x;
            x = 0;
            for (int i = 1; i <= 12; i++)
            {
                int y;
                y = 0;
                if (i == 10)
                {
                    y = i + 200;
                    x = i + 500;
                }
                else
                {
                    y = y + i;
                    x = x + i;
                }
               
            }
            Console.WriteLine("Value of x : " + x);
            Console.ReadLine();
        }

        public void castMethods()
        {
            int i1;
            double d1,d2;
            string s1;
            char c1;
            float f1;
            i1= 145;
            d1 = 456.456;
            d2 = 2.5;
            i1 = (int) d1;
            Console.WriteLine("Int value of d1 is {0}",i1);
            Console.WriteLine(" Math.Sqrt(d1) is {0}", Math.Sqrt(d1));
            Console.WriteLine(" (int)Math.Sqrt(d2 * d2) is {0}", (int)Math.Sqrt(d2 * d2));
            Console.WriteLine("Sqrt value of d2 is {0}", (int) Math.Sqrt(d1)-(int)Math.Sqrt(d2 * d2));
            Console.ReadLine();

        }
    }
}
