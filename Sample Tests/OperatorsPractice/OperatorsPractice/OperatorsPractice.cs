using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperatorsPractice
{
    class OperatorsPractice
    {

        public void DivisionPractice()
        {
            Console.WriteLine(" Result of 10/3 is {0}", 10 / 3);
            Console.WriteLine(" Result of 10%3 is {0}", 10 % 3);
            Console.WriteLine(" Result of 10.0/3.0 is {0}", 10.0 / 3.0);
            Console.WriteLine(" Result of 10.0/3.0 is {0}", 10.0 % 3.0);
            Console.ReadLine();
        }
        public void IncrementOperator()
        {
            int x, y;
            y = 0;
            x = 1;
            Console.WriteLine(" y = y + x++ result is\n");
            for (int i = 0; i < 10; i++)
            {
                y = y + x++;
                Console.WriteLine(y + " ");
            }
            Console.WriteLine(" y = y + ++x result is\n");
            y = 0;
            x = 1;
            for (int i = 0; i < 10; i++)
            {
                y = y + ++x;
                Console.WriteLine(y + " ");
            }
            Console.ReadLine();
        }

        public void LogicalOperators()
        {
            int x = 5;
            int y = 8;
            bool a1 = false;
            bool b1 = false;

            if (x != y)
            {
                Console.WriteLine("x is not equal to y");
            }
            if (x < y)
            {
                Console.WriteLine("x is less than y");
            }
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            if (x <= y)
            {

                Console.WriteLine(" x <= y");
            }
            if (x >= y)
            {
                Console.WriteLine(" x >= y");
            }

            if(x==5|| y==8)
                Console.WriteLine(" Either X=5 or y=8");
            if(x==5 && y==8)
                Console.WriteLine("x=5 and y=8");
            if (b1)
                Console.WriteLine("b1 is True");
            else
                Console.WriteLine("b1 is False");
            if (a1)
                Console.WriteLine("a1 is True");
            else
                Console.WriteLine("a1 is False");

            if (a1 | !b1)
                Console.WriteLine("a1 is " + a1 + " b1 is " + b1);
            if(a1&!b1)
                Console.WriteLine("a1 is " + a1 + " b1 is " + b1);
            if(a1^b1)
                Console.WriteLine("a1 ^ b1");
            if (!a1)
                Console.WriteLine("a1 is false");

            Console.ReadLine();
        }

        public void Assignment()
        {
            int x=0;
            int y = 78;
            int a = 1;
            int b = 479001600;
            long c = 4790016000;
            for (int i = 1; i <= 12; i++)
            {
                x += i;
                y -= i;
                a *= i;
                b /= i;
                //c %= i;
            }
            Console.WriteLine(" x += i is " + x);
            Console.WriteLine(" y -= i is " + y);
            Console.WriteLine(" a *= i is " + a);
            Console.WriteLine(" b /= i is " + b);
            Console.WriteLine(" c %=2001  is " + (c %= 2001));
            Console.WriteLine(" c |=2001  is " + (c |= 2001));
            Console.WriteLine(" c &=2001  is " + (c &= 2001));
            Console.WriteLine(" c ^=2001  is " + (c ^= 2001));
            Console.ReadLine();
        }

        public void ConvertOddToEvenBitwise()
        {
            ushort num =0;
            ushort i =0;
            for (i = 1; i <= 10; i++)
            {
                num = i;
                Console.WriteLine("num: " + num);
                Console.WriteLine("num after turning off bit zero: " + (num & 0xFFFE) + "\n");
                num = (ushort)(num & 0xFFFE);
                Console.WriteLine("num after turning off bit zero: " + num + "\n");
            }
            Console.ReadLine();
       }
                    
    }
}
