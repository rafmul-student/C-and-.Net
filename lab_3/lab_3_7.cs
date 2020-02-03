using System; 
namespace lab_7
{
    class Program
    {
        static int maxIntValue = 2147483647;
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("\nPrzepełnienie");
            n = maxIntValue;
            Console.WriteLine(n);
            n += 110;
            Console.WriteLine(n);
            Console.WriteLine();
            try
            {
                n = checked(maxIntValue + 11);
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("Błąd przepełnienia.");
            }
        }
    }
}
