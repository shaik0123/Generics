using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public  class GenricArray
    {
        public static void ToPrint<T>(T[] inputArray)
        {
            foreach (var i in inputArray)
            {
                Console.WriteLine(i);
            }

        }
    }
}
