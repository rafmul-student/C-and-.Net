using System;
using System.Threading;
using System.Threading.Tasks;
namespace lab_3
{
    class Program
    {
        static void Main()
        {
            Task.Factory.StartNew(Run);
        }

        static void Run()
        {
            Console.WriteLine("Hello !! The thread pool!");
        }
    }
}

// Nie zostało nic wyświetlone.
