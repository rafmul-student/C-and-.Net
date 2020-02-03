using System; 
namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> zm;
            //Console.WriteLine(zm);                         // Nie udało się
            //Console.WriteLine(zm.GetValueOrDefault());     // Nie udało się
            //Console.WriteLine(zm.HasValue);                // Nie udało się
            zm = 3;
            Console.WriteLine(zm);                       
            Console.WriteLine(zm.GetValueOrDefault());   
            Console.WriteLine(zm.HasValue);
            zm = null;
            Console.WriteLine(zm);
            Console.WriteLine(zm.GetValueOrDefault());
            Console.WriteLine(zm.HasValue);
        }
    }
}
