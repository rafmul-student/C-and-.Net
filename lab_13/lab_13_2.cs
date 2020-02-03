using System;
using System.Threading;
namespace lab_2
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Cwiczenie 2");

            new Thread(Run).Start();
        }

        static void Run()
        {
            try
            {
                throw null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception!");
            }
        }
    }
}
// Program wyświetla wszystko poprawnie, uważam że należy zastosować drugie rzzwiązanie, ponieważ program nie przerywa działania nawet gdy zostaje przerwany jeden z wątków
