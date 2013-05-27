using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Management.Instrumentation;
using FlashAccessibility;
namespace test
{
    class file
    {
        string path = "G:\\test\\text1.txt";
        static void Main()
        {
            file ob = new file();
            //File.Create(ob.path);
           
            StreamWriter sw = File.CreateText(ob.path);
            
            for (int i = 0; i <= 100; i++)
            {

                

            }

        }
    
    }
  
}