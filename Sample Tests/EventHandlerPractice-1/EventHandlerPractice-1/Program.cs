using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public delegate void EventHandler();
namespace EventHandlerPractice_1
{
    public delegate void NewDelegate(int x, int y);
    class Program
    {   
        static event EventHandler _status;
        static void Main(string[] args)
        {
            try
            {
                _status += new EventHandler(cat);
                NewDelegate DelProd = new NewDelegate(Mul);
                DelProd += new NewDelegate(Div);
                DelProd(10, 0);
                //Console.WriteLine("From Delegate Result : " + DelProd(10, 5));
                Console.ReadLine();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }

        public static void cat()
        {
            Console.WriteLine("Cat instance is called");
        }

        public static void Mul(int x, int y)
        {
            //return x * y;
            Console.WriteLine(" Product is : " + x * y);
            
           
        }
        public static void Div(int x, int y)
        {
            //return x / y;
            Console.WriteLine(" Product is : " + x / y);

        }

    
        
    }
}
