using System; 
namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int tmp_int;
            float tmp_float;
            int licz_inty = 0;
            int licz_floaty = 0;
            int licz_stringi = 0;
            while((input = Console.ReadLine()) != "-1")
            {
                Console.WriteLine("Podaj int, float lub string:");
                if (int.TryParse(input, out tmp_int))
                {
                    licz_inty += 1;
                }
                else if (float.TryParse(input, out tmp_float))
                {
                    licz_floaty += 1;
                }
                else
                {
                    licz_stringi += 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Zmiennych typu int: " + licz_inty.ToString());
            Console.WriteLine("Zmiennych typu float: " + licz_floaty.ToString());
            Console.WriteLine("Zmiennych typu string: " + licz_stringi.ToString());
        }
    }
}
