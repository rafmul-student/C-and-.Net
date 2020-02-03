using System;
using System.Threading;
namespace lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(Run);
            t.Start();        
            Console.WriteLine("Thread t has ended");
        }

        static void Run()
        {
            for(int i = 0; i < 777; i++)
            {
                Console.Write("[]");
            }
        }
    }
}

// Bez funkcji Join() progra, od razu wypisuje "Thread t has ended" nie czekając na wykonanie wątku
