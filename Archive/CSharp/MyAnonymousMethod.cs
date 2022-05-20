using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP_Tech.CSharp
{
    public static class MyAnonymousMethod
    {
        //http://vpaste.net/q9Itu About AnonymousMethod

        public delegate void Print(int value);

        public static void CreateAnonymousMethod1()
        {
            Print print = delegate (int val)
            {
                Console.WriteLine("Inside Anonymous method. Value: {0}", val);
            };

            print(100); //Inside Anonymous method. Value: 100
        }
        public static void CreateAnonymousMethod2()
        {

            int i = 10;

            Print prnt = delegate (int val)
            {
                val += i;
                Console.WriteLine("Anonymous method: {0}", val);
            };

            prnt(100);
        }
        public static void PrintHelperMethod(Print printDel, int val)
        {
            val += 10;
            printDel(val);
        }
        public static void CreateAnonymousMethod3()
        {
            PrintHelperMethod(delegate (int val) { Console.WriteLine("Anonymous method: {0}", val); }, 100);
        }

    }
}
