using System;
namespace lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while(input != "q")
            {
                Console.Write("\nWejście: ");
                input = Console.ReadLine();
                for(int i = input.Length - 1; i > 0; i--)
                {
                    input = input.Insert(i, " ");
                }
                Console.WriteLine("Wyjście: " + input);
            }
        }
    }
}
