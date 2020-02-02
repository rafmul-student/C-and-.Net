using System;
namespace lab_2
{
    class Program
    {
        public unsafe static void Main(string[] args)
        {
            int[] list = { 10, 100, 200 };
            fixed (int *ptr = list)
            for (int i=0; i < 3; i++)
            {
                Console.WriteLine("Adres [{0}] = {1}", i, (int)(ptr + i));
                Console.WriteLine("Wartość [{0}] = {1}", i, *(ptr + i));
            }
            fixed (int *ptr = list)
            swap(ptr, ptr + 2);
            fixed (int* ptr = list)
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Adres [{0}] = {1}", i, (int)(ptr + i));
                Console.WriteLine("Wartość [{0}] = {1}", i, *(ptr + i));
            }
            int[] buffor = new int[1024];
            fixed(int *ptr = buffor)
            {
                for (int i=0; i<1024; i++)
                {
                    *(ptr + i) = i;
                }
                for(int i=0; i<5; i++)
                {
                    Console.WriteLine("Adres [{0}] = {1}", i, (int)(ptr + i));
                    Console.WriteLine("Wartość [{0}] = {1}", i, *(ptr + i));
                }
                for (int i = 456; i < 506; i++)
                {
                    Console.WriteLine("Adres [{0}] = {1}", i, (int)(ptr + i));
                    Console.WriteLine("Wartość [{0}] = {1}", i, *(ptr + i));
                }
                for (int i = 798; i < 811; i++)
                {
                    Console.WriteLine("Adres [{0}] = {1}", i, (int)(ptr + i));
                    Console.WriteLine("Wartość [{0}] = {1}", i, *(ptr + i));
                }
                for (int i = 1018; i < 1024; i++)
                {
                    Console.WriteLine("Adres [{0}] = {1}", i, (int)(ptr + i));
                    Console.WriteLine("Wartość [{0}] = {1}", i, *(ptr + i));
                }
            }

        }
        public unsafe static void swap(int* p, int* q)
        {
            int temp = *p;
            *p = *q;
            *q = temp;
        }
    }
}
