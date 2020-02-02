using System;
using System.Threading;

namespace Cwiczenie_3
{
    class ThreadTest
    {
        bool done;
        static void Main(string[] args)
        {

            ThreadTest tt = new ThreadTest();
            new Thread(tt.Run).Start();
            tt.Run();
        }

        void Run()
        {
            if (!done)
            {
                done = true;
                Console.WriteLine("Done"); 
            }
        }
    }
}


// Funkcja została wywołana raz, bo zmienna done zmieniła swoją wartość zanim weszła do drugiego wątku
