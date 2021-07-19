using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CSharpOOP_Tech
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a1 = new string[] { "arp", "live", "strong" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };

            var r = inArray(a1, a2);




            Console.WriteLine("Hello World!");
        }

        public static string[] inArray(string[] array1, string[] array2)
        {
            List<string> r = new List<string>();

            for (int index = 0; index < array1.Length; index++)
            {
                var item = array1[index];
                if (array2.Any(arr => arr.Contains(item)))
                {
                    r.Add(item);
                }
            }
            return r.Distinct().ToArray();
        }
    }
}
