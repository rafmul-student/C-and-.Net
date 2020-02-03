using System;
using System.Threading;
namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {

            new Thread (Run).Start();    
            Run();
        }

        static void Run()
        {
            for(int cycles = 0; cycles < 5; cycles++)
            {
                Console.Write('x');
            }
        }
    }
}


// Wypisywanie odbywa się 10 razy, bo funkcja Run() wywoływana jest dwukrotnie
