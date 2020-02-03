using System; 
namespace lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            bool samogloska = false;
            char[] samogloski = new char[] { 'a', 'ą', 'e', 'ę', 'i', 'o', 'ó', 'u', 'y', 'A', 'Ą', 'E', 'Ę', 'I', 'O', 'U', 'Ó', 'Y' };
            Console.WriteLine("\nPodaj symbol: ");
            while((input = Console.ReadLine()) != "-1")
            {
                samogloska = false;
                if(input.Length != 1)
                {
                    Console.WriteLine("Niepoprawna liczba znaków.\n");
                    continue;
                }
                if(char.IsDigit(char.Parse(input)))
                {
                    Console.WriteLine("To cyfra");
                }
                else
                {
                    for(int i=0; i < samogloski.Length; i++)
                    {
                        if(char.Parse(input) == samogloski[i])
                        {
                            samogloska = true;
                            break;
                        }
                    }
                    if(samogloska)
                    {
                        Console.WriteLine("To samogłoska");
                    }
                    else
                    {
                        Console.WriteLine("To nie samogłoska");
                    }
                }
                Console.WriteLine("\nPodaj symbol: ");
            }
        }
    }
}
