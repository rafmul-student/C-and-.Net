using System; 
namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[5];
            string input;
            bool isError = false;
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write("Podaj {0} liczbę typu int: ", i + 1);
                input = Console.ReadLine();
                if(!int.TryParse(input, out tablica[i]))
                {
                    Console.WriteLine("To nie jest int :(");
                    isError = true;
                    break;
                }
            }
            if (!isError)
            {
                Console.WriteLine("Liczby:");
                for (int i = 4; i >= 0; i--)
                {
                    Console.WriteLine(tablica[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
