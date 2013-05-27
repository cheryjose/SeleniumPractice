using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Class1
    {
    }
    public class FirstProgram
    {

        public void Main()
            {
                System.Console.WriteLine("Hello, Microsoft .Net Framework!");

            }

        public string Inheritence(string name)
        {
            string Str1=name;
            int a,length;
            a = Str1.Count();
            length=Str1.Length;
            return Str1;
        }
    }
}
