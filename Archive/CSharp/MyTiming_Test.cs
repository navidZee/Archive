using System;
using System.Text;
using System.Collections.Generic;

namespace CSharpOOP_Tech.CSharp
{
    public class MyTiming_Test
    {
        static void MyTiming_TestMain(string[] args)
        {
            DateTime starTime;
            TimeSpan duration;
            int[] nums = new int[100000];
            arrayBuilder(nums);
            starTime = DateTime.Now;
            outputArray(nums);
            duration = DateTime.Now.Subtract(starTime);
            Console.WriteLine("\n Time is : " + duration.TotalSeconds);
            Console.Read();
        }

        static void arrayBuilder(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
        }

        static void outputArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}