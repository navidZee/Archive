using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP_Tech.CSharp
{
    public static class MyStringBuilder
    {
        public static void CreateStringBuilder()
        {
            //http://vpaste.net/u61Zm

            StringBuilder sb1 = new StringBuilder("Hello World!!", 50 /*Optional*/); // 50 Max Length


            //Append()/AppendLine()
            StringBuilder sb2 = new StringBuilder("Hello ", 50);

            sb2.Append("World!!");
            sb2.AppendLine("Hello C#!");
            sb2.AppendLine("This is new line.");

            Console.WriteLine(sb2);
            //Hello World!!Hello C#!.
            //This is new line.


            //AppendFormat()
            StringBuilder amountMsg = new StringBuilder("Your total amount is ");
            amountMsg.AppendFormat("{0:C} ", 25);
            Console.WriteLine(amountMsg); //Your total amount is $ 25.00

            //Insert()
            StringBuilder sb3 = new StringBuilder("Hello World!!", 50);
            sb3.Insert(5, " C#");
            Console.WriteLine(sb3); //Hello C# World!!

            //Remove()
            StringBuilder sb4 = new StringBuilder("Hello World!!", 50);
            sb4.Remove(6, 7);
            Console.WriteLine(sb4); //Hello

            //Replace()
            StringBuilder sb = new StringBuilder("Hello World!!", 50);
            sb.Replace("World", "C#");
            Console.WriteLine(sb); //Hello C#!!
    

            //http://vpaste.net/zFGvv main Method For StringBuilder

        }
    }
}
