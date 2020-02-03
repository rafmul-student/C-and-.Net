using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab_5
{
    class Program
    {
        static void Main()
        {
            Func<string, int> method = Do;
            IAsyncResult cookie = method.BeginInvoke("test", null, null);
            int result = method.EndInvoke(cookie);
            Console.WriteLine("String length is: " + result);
        }

        static int Do(string s) 
        { 
            return s.Length; 
        }
    }
}

// Zostało wyświetlone
// String length is: 4
// Używając .NET Core, wyskakuję nie obsługiwanie wątków
