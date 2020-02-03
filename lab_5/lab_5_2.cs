using System;
namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 i = 23;
            object o = i;
            i = 123;
            Console.WriteLine(i + ", " + (Int32) o);
            long j = (long)o;
            Console.WriteLine(j + ", " + (Int32)o);
        }
    }
}
