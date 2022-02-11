using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP_Tech.CSharp.DesignPattern.Creational.Singleton
{
    public class MemoryCache
    {
        private static int i = 0;
        private static MemoryCache _instance;
        private static object _cacheLock = new object();

        private MemoryCache()
        {
            Console.WriteLine("Created" + i++);
        }

        public static MemoryCache Create()
        {
            if (_instance is null)
            {
                lock (_cacheLock)
                {
                    if (_instance is null)
                    {
                        _instance = new MemoryCache();
                    }
                }
            }

            return _instance;
        }
    }
}
