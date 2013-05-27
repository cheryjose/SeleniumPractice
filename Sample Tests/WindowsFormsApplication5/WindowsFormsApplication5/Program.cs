using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
//using System.Threading;
using System.Timers;
namespace WindowsFormsApplication5
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static string str;
        //static event ElapsedEventHandler Elapsed;
        
        [STAThread]
        static void Main()
        {
            ADOTest obj1 = new ADOTest();
            //Thread oThread = new Thread(ThreadStart strt());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            System.Timers.Timer timer = new System.Timers.Timer(10000);
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Interval = 1000; //1000ms = 1sec
            timer.Enabled =true;
            //timer.Stop();
            //obj1.SqlTest("Select * from HumanResources.Department");
            //MessageBox.Show(obj1.SqlTest());
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            MessageBox.Show("The Elapsed event was raised at {0}"+e.SignalTime);
        }
    }
}
