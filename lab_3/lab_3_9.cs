using System;

namespace lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string input;
            bool isError = false;
            int int_to_try;
            while ((input = Console.ReadLine()) != "q")
            {
                string[] liczby = input.Split(new Char[] { '+', '-' });
                foreach (string s in liczby)
                {
                    if(!int.TryParse(s, out int_to_try))
                    {
                        isError = true;
                    }    
                }
                if(isError)
                {
                    isError = false;
                    Console.WriteLine("ERROR");
                    continue;
                }
                string[] dzialania = input.Split(new Char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
                string[] temporary = new string[dzialania.Length - 2];
                for (int i = 1; i < (dzialania.Length - 1); i++)
                {
                    temporary[i - 1] = dzialania[i];
                }
                dzialania = temporary;
                count = int.Parse(liczby[0]);
                for(int i = 1; i < liczby.Length; i++)
                {
                    if(dzialania[i-1] == "+")
                    {
                        count += int.Parse(liczby[i]);
                    }
                    if(dzialania[i-1] == "-")
                    {
                        count -= int.Parse(liczby[i]);
                    }
                }
                Console.WriteLine(count);
            }
        }
    }
}
