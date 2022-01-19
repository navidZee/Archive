using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CSharpOOP_Tech
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new int[] { 5, 3, 7, 0, -9, 16, 67, 13 };
            InsertionSort(ref x);
        }


        private static void InsertionSort(ref int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i],
                    j = i - 1;

                while (j > -1 && array[j] > key)
                {
                    array[j + 1] = key; //swap
                    j -= 1;
                }

                array[j + 1] = key;
            }
        }
    }
}
