using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Lab_1
{
    class Program
    {
        public static void Main()
        {
            try
            {
                new Thread(Run).Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception!");
            }
        }
        static void Run() { throw null; }
    }
}


// Program wyświetla w aplikacji konsoli napis "Excepion!"
// w porównaniu do zadania 1, w tym zadaniu każdy z wątków został obsłużony
//uważam, że lepiej zastosować drugą z metod ze względu na możliwe nie wyświetlenie pierwszej

// Przy kompilacji wyskakuję, że wątek jest nieobsługiwany. Zarówno korzystając z aplikacji .NET Core jak i .NET Framework 
