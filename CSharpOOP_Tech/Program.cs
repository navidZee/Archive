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
            Console.WriteLine(jumpingOnClouds(new List<int>() { 0, 0, 0, 1, 0, 0 }));
        }
        public static int jumpingOnClouds(List<int> c)
        {
            int jump = 0;
            for (int i = 0; i < c.Count; i++)
            {
                if ((i + 1) > c.Count || (c[i + 1] == 0)) i++;
                jump++;
            }

            return jump;
        }
    }
}