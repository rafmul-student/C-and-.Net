using System;
using System.Threading;

namespace Cwiczenie_4
{
    class Program
    {
        static void Main()
        {
            ThreadPool.QueueUserWorkItem(Run);
            ThreadPool.QueueUserWorkItem(Run, 123);
            Console.ReadLine();
        }

        static void Run(object data)
        {
            Console.WriteLine("Hello !! The thread pool! " + data);
        }
    }
}

// Zostało wyświetlone:
// Hello !! The thread pool!
// Hello !! The thread pool! 123
