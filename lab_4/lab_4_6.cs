using System;
namespace lab_6
{
    class Program
    {
       static void Main(string[] args)
        {
            int[,] tablica1 = new int[,] { {1, 2, 3, 4, 5 },
                                       {6, 7, 8, 9, 10},
                                       {11, 12, 13, 14, 15},
                                       {16, 17, 18, 19, 20},
                                       {21, 22, 23, 24, 25} };
            int[,] tablica2 = new int[,] { {1, 2, 3, 4, 5 },
                                       {6, 7, 8, 9, 10},
                                       {11, 12, 13, 14, 15},
                                       {16, 17, 18, 19, 20},
                                       {21, 22, 23, 24, 25} };
            int[,] tablica3 = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    tablica3[i, j] = tablica2[i, j] + tablica1[i, j];
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("[{0,2}]", tablica1[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("[{0,2}]", tablica2[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("[{0,2}]", tablica3[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nLength: {0}", tablica3.Length);
            Console.WriteLine("LongLength: {0}", tablica3.LongLength);
            Console.WriteLine("Rank: {0}", tablica3.Rank);
        }
    }
}
