using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Max<T> where T : IComparable<T>
    {

         public static void PrintMaxInt(int a,int b,int c)
         {
             if (a > b && a > c)
             {
                 Console.WriteLine("a is max : "+a);
             }
             else if (b > a && b > c)
             {
                 Console.WriteLine("b is max : "+b);
             }
             else
             {
                 Console.WriteLine("c is max : "+c);
             }
         }
         public static void PrintMaxFloat(float a, float b, float c)
         {
             if (a > b && a > c)
             {
                 Console.WriteLine("a is max : "+a);
             }
             else if (b > a && b > c)
             {
                 Console.WriteLine("b is max : "+b);
             }
             else
             {
                 Console.WriteLine("c is max : "+c);
             }
         }
         public static void PrintMaxString(string a, string b, string c)
         {
             if ( a.Length > b.Length && a.Length > c.Length)
             {
                 Console.WriteLine("a is max : " + a);
             }
             else if (b.Length > a.Length && b.Length > c.Length)
             {
                 Console.WriteLine("b is max : " + b);
             }
             else
             {
                 Console.WriteLine("c is max : " + c);
             }
         }




        private  T  a;
        private T b;
        private T c;
        public Max(T a,T b,T c) { 
            this.a = a; 
            this.b = b; 
            this.c = c;
        }

        public static T PrintMax(T a, T b, T c)
        {
            
            if (a.CompareTo(b) > 0)
            {
                Console.WriteLine("a is max : " + a);
                return a;
            }
            else if (b.CompareTo(c)>0)
            {
                Console.WriteLine("b is max : " + b);
                return b;
            }
            else
            {
                   Console.WriteLine("c is max : " + c);
                return c;
            }
            return default;
        }
        public T ShowMax()
        {
            T max = Max<T>.PrintMax(a, b, c);
            return max;

        }
    }
}
