using System;
namespace lab_3
{
    class Program
    {
        delegate float delegata(int n1, int n2);

        static void Main(string[] args)
        {
            delegata d = new delegata(dodaj);
            d += new delegata(odejm);
            d += new delegata(podziel);
            d += new delegata(pomnoz);
            int n1 = 4;
            int n2 = 10;
            d(n1, n2);
        }
        public static float dodaj(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
            return n1 + n2;
        }
        public static float odejm(int n1, int n2)
        {
            Console.WriteLine(n1 - n2);
            return n1 - n2;
        }
        public static float pomnoz(int n1, int n2)
        {
            Console.WriteLine(n1 * n2);
            return n1 * n2;
        }
        public static float podziel(int n1, int n2)
        {
            Console.WriteLine(n1 / n2);
            return n1 / n2;
        }
    }
}
