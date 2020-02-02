using System;
using System.Collections.Generic;
namespace lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stos = new Stack();
            stos.AddItem(3);
            stos.PrintAllItems();
            stos.AddItem(6);
            stos.PrintAllItems();
            stos.AddItem(3);
            stos.PrintAllItems();
            stos.AddItem(1);
            stos.PrintAllItems();
            stos.AddItem(4);
            stos.PrintAllItems();
            stos.AddItem(5);
            stos.PrintAllItems();
            stos.AddItem(8);
            stos.PrintAllItems();
            stos.AddItem(7);
            stos.PrintAllItems();
            stos.DeleteItem();
            stos.PrintAllItems();
            Console.WriteLine("..............");
            stos.ShowMinItem();
            stos.ShowMaxItem();
            Console.WriteLine("{0}", stos.FindAnItem(0));
            Console.WriteLine("{0}", stos.FindAnItem(1));
            Console.WriteLine("{0}", stos.FindAnItem(2));
            Console.WriteLine("{0}", stos.FindAnItem(3));
            stos.ClearAll();
            stos.PrintAllItems();
            Random rnd = new Random();
            Stack stos1 = new Stack();
            Stack stos2 = new Stack();
            Stack stos3 = new Stack();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("{0}", rnd.Next(1, 100));
                stos1.AddItem(rnd.Next(1, 100));
                stos2.AddItem(rnd.Next(1, 100));
            }
            for(int i = 0; i <= 100; i++)
            {
                if((stos1.FindAnItem(i) >= 0) || (stos2.FindAnItem(i) >= 0))
                {
                    if(i % 2 == 0)
                    {
                        stos3.AddItem(i);
                    }
                }
            }
            stos1.PrintAllItems();
            stos2.PrintAllItems();
            stos3.PrintAllItems();
        }
    }
    class Stack
    {
        List<int> mem = new List<int>();
        public void AddItem(int item)
        {
            mem.Add(item);
        }
        public void DeleteItem()
        {
            mem.Remove(mem[0]);
        }     
        public void ShowTheNumberOfItems()
        {
            Console.WriteLine("Liczba: " + mem.Count.ToString());
        } 
        public void ShowMinItem()
        {
            int min = 0;
            if(mem.Count > 0)
            {
                min = mem[0];
            }
            for (int i = 0; i < mem.Count; i++)
            {
                if (min > mem[i])
                {
                    min = mem[i];
                }
            }
        }
        public void ShowMaxItem()
        {
            int max = 0;
            if (mem.Count > 0)
            {
                max = mem[0];
            }
            for (int i = 0; i < mem.Count; i++)
            {
                if (max < mem[i])
                {
                    max = mem[i];
                }
            }
        }    
        public int FindAnItem(int item)
        {
            for(int i = 0; i < mem.Count; i++)
            {
                if(mem[i] == item)
                {
                    return i;
                }
            }
            return -1;
        }
        public void PrintAllItems()
        {
            for ( int i = 0; i < mem.Count; i++)
            {
                Console.Write("[{0}]", mem[i]);
            }
            Console.WriteLine();
        }
        public void ClearAll()
        {
            mem.Clear();
        }
    }
}
