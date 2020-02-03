using System;
using System.Threading;
namespace lab_4
{
    class ThreadExample
    {
        static bool done;

        static void Main(string[] args)
        {
            new Thread (Run).Start();
            Run();
        }
        static void Run()
        {
            if (!done)
            {
                Console.WriteLine("Done");
                done = true;

                
            }
        }
    }
}


// Po zmianie kolejności słowo "Done" pojawia się 2 razy, 
// spowodowane jest tym, że drugi wątek zdąży wejść w warunek zanim zmienna zmieni wartość
