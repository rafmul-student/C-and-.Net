using System;
namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int? i = null;
            int j = 10;
            Console.WriteLine(i < j);
            Console.WriteLine(i == j);
            Console.WriteLine(i > j);
        }
    }
}
