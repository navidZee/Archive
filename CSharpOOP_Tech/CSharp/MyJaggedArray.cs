using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP_Tech.CSharp
{
    public static class MyJaggedArray
    {
        // A jagged array is an array of array. Jagged arrays store arrays instead of literal values.
        public static void CreateJaggedArray()
        {

            int[][] intJaggedArray = new int[2][];

            intJaggedArray[0] = new int[3] { 1, 2, 3 };

            intJaggedArray[1] = new int[2] { 4, 5 };

            Console.WriteLine(intJaggedArray[0][0]); // 1
            Console.WriteLine(intJaggedArray[0][2]); // 3
            Console.WriteLine(intJaggedArray[1][1]); // 5


            int[][,] intJaggedMatrixArray = new int[3][,];

            intJaggedMatrixArray[0] = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            intJaggedMatrixArray[0] = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            intJaggedMatrixArray[0] = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            Console.WriteLine(intJaggedMatrixArray[0][1, 1]); // 4                              
            Console.WriteLine(intJaggedMatrixArray[1][1, 0]); // 5                              
            Console.WriteLine(intJaggedMatrixArray[1][1, 1]); // 6


            // More example https://www.tutorialsteacher.com/csharp/csharp-jagged-array

        }
    }
}
