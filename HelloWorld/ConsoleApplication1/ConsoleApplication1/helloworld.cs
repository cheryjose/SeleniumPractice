using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

   class helloworld
    {
        static void Main(string[] args)
        {
            #if DebugConfig
            Console.WriteLine("WE ARE IN THE DEBUG CONFIGURATION");
            #endif
            Console.WriteLine("Hello, world!");
        }
    }

