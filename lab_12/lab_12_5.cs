using System;
using System.Threading;
namespace lab_5
{
    class ThreadExample
    {
        static readonly object locker = new object();
        static bool done;

        static void Main(string[] args)
        {
            new Thread(Run).Start();
            Run();
        }

        static void Run()
        {
            lock (locker)
            {
                if (!done)
                {
                    Console.WriteLine("Done");
                    done = true;
                }
            }
        }
    }
}
