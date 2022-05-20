using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP_Tech.CSharp
{
    public static class MyVarType
    {

        public static void CreateMyVarType()
        {
            //http://vpaste.net/0Cb4h About VarType

            int i1 = 100;// explicitly typed 
            var i2 = 100; // implicityly type

            var i3 = 10;
            Console.WriteLine("Type of i is {0}", i3.GetType().ToString());

            var str = "Hello World!!";
            Console.WriteLine("Type of str is {0}", str.GetType().ToString());

            var d = 100.50d;
            Console.WriteLine("Type of d is {0}", d.GetType().ToString());

            var b = true;
            Console.WriteLine("Type of b is {0}", b.GetType().ToString());
        }



    }
}
