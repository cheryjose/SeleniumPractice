using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestNameSpace
{
    class TestClass1
    {

        int[] ArrInt1 = new int[3];
        string[] ArrString1 = new string[3];
        float[] ArrFloat1= new float[3];
        double[] ArrDouble1 = new double[3];
        int[] ArrInt2 = new int[3];
        int[,] ArrMultInt1 = new int[2, 3];

        public int MultiArrayMethod()
        {

            for (int i = 0; i <= 1; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    ArrMultInt1[i, j] = i + j;
                    //Console.WriteLine(ArrMultInt1[i, j]);
                }
            }


            foreach (int intval in ArrMultInt1)
            {
                               
                Console.WriteLine(Convert.ToString(intval));

            }

            return ArrMultInt1[1, 2];
        }

        public int ArrayMethod()
        {
            for (int i = 0; i <= 2; i++)
            {
                ArrInt1[i] = i;
                
            }
            return ArrInt1[2];
            
         }
    }
}
