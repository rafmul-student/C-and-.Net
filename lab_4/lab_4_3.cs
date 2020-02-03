using System; 
namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[10];
            int n;
            string input;
            Console.Write("\nPodaj liczbę: ");
            while ((input = Console.ReadLine()) != "q")
            {
                if (!int.TryParse(input, out n))
                {
                    Console.WriteLine("To nie jest int :( ");
                    Console.Write("\nPodaj liczbę typu int: ");
                    continue;
                }
                for (int i=8; i>=0; i--)
                {
                    tablica[i + 1] = tablica[i];
                }
                tablica[0] = n;
                for(int i=0; i<10; i++)
                {
                    Console.Write("[{0}]", tablica[i]);
                }
                Console.WriteLine();
                Console.Write("\nPodaj liczbę: ");
            }            
        }
    }
}
