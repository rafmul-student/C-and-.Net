using System;
namespace lab_5
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
                Console.Write("Podaj {0} wartość tablicalicy: ", i + 1);
                input = Console.ReadLine();
                if (!int.TryParse(input, out tablica[i]))
                {
                    Console.WriteLine("To nie int :(");
                    isError = true;
                    break;
                }
                else;
            }
            if(isError)
            {
                return;
            }
            int powtorka = 0;
            int[] powtarza_sie = new int[] { -1, -1, -1, -1, -1 };
            int[] zlicz = new int[] { -1, -1, -1, -1, -1 };
            int count;

            for (int i = 0; i < tablica.Length; i++)
            {
                count = 0;
                for (int j = 0; j < powtarza_sie.Length; j++)
                {
                    if (tablica[i] == powtarza_sie[j])
                    {
                        count++;
                    }
                }
                if(count > 0)
                {
                    continue;
                }
                count = 1;
                for (int j = i + 1; j < tablica.Length; j++)
                {
                    if (tablica[i] == tablica[j])
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    powtarza_sie[powtorka] = tablica[i];
                    zlicz[powtorka] = count;
                    powtorka++;
                }
            }
            Console.WriteLine("\n\nLiczby powtarzające się:");
            for(int i = 0; i < powtorka; i++)
            {
                Console.WriteLine("\nWartość: {0}\nPowtórzenia: {1}", powtarza_sie[i], zlicz[i]);
            }
        }
    }
}
