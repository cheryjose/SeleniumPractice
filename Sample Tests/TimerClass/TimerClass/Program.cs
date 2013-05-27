using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace TimerClass
{
    class Program
    {
        static System.Timers.Timer timer = new System.Timers.Timer();
        static int count = 0;
        static void Main(string[] args)
        {
            
            //Application.Run(new Form1());
           
            timer.Interval = 2000; //1000ms = 1sec
            timer.Enabled = true;
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            
            Console.WriteLine("Press the Enter key to exit the program.");
            Console.ReadLine();
            //timer.Stop();
            //obj1.SqlTest("Select * from HumanResources.Department");
            //MessageBox.Show(obj1.SqlTest());
            GC.KeepAlive(timer);
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            
            Console.WriteLine("The Elapsed event was raised at {0}" + e.SignalTime);
            Timer timer = (Timer)source;
            count = count + 1;
            if (count == 3)
            {
                timer.Stop();
            }
           
        }
    }
}
