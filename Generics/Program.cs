using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
             /*Max.PrintMaxInt(3,2,1);
             Max.PrintMaxFloat(1.1f,2.1f,3.1f);
             Max.PrintMaxString("ab", "abcd", "abc");*/
            
            int a = new Max<int>(1,2,3).ShowMax();
            
            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 2.1, 1.1, 3.1 };
            char[] charArray = { 'a','b', 'c' };

            PrintArrays.ToPrint(intArray);
            PrintArrays.ToPrint(doubleArray);
            PrintArrays.ToPrint(charArray);
           
            Console.WriteLine("#############################");

            GenricArray.ToPrint<int>(intArray);
            GenricArray.ToPrint<double>(doubleArray);
            GenricArray.ToPrint<char>(charArray);
        }
    }
}
