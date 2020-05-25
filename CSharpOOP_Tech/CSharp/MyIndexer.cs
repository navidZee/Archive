using System;

namespace CSharpOOP_Tech.CSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            CreateIntegerIndex oIndex = new CreateIntegerIndex();

            oIndex[0] = 12;
            oIndex[0] = 22;
            oIndex[0] = 80;

            for (int i = 0; i < 22; i++)
            {
                System.Console.WriteLine(oIndex[i]);
            }

            CreateBooleanIndex oIntBits = new CreateBooleanIndex();
            oIntBits[0] = false;
            oIntBits[1] = true;
            Console.ReadKey();
        }
    }

    class CreateIntegerIndex
    {
        private int[] ages = new int[22];
        public int this[int index]
        {
            get
            {
                return ages[index];
            }
            set
            {
                ages[index] = value;
            }
        }
    }

    class CreateBooleanIndex
    {
        private bool[] blnArray = new bool[32];
        public bool this[int index]
        {
            get
            {
                return blnArray[index];
            }
            set
            {
                blnArray[index] = value;
            }
        }

    }

 
}