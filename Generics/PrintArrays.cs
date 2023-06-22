using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public  class PrintArrays
    {
        public static void ToPrint(int[] inputArray)
        {
            foreach (int i in inputArray) 
            {
                Console.WriteLine(i);
            }

        }
        public static void ToPrint(double[] inputArray)
        {
            foreach (double i in inputArray)
            {
                Console.WriteLine(i);
            }

        }
        public static void ToPrint(char[] inputArray)
        {
            foreach (char i in inputArray)
            {
                Console.WriteLine(i);
            }

        }
    }
}
