using System;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP_Tech.CSharp.DesignPattern.Creational.Singleton
{
    public class SingletonPattern
    {
        void Main()
        {
            int size = 8;
            Task[] tasks = new Task[size];
            for (int i = 0; i < size; i++)
            {
                tasks[i] = Task.Run(() => MemoryCache.Create());
            }
            Task.WaitAll(tasks);
        }
    }
}
