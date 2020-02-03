using System;
namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ChristmasTree choinka = new ChristmasTree();
            choinka.wyswietl();
        }
    }

    class ChristmasTree
    {
        int count = 15;
        Random rnd = new Random();
        int rand;

        public void wyswietl()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(500);
                Console.SetCursorPosition(0, 2);
                for (int i = 0; i <= count; i++)
                {
                    for (int j = i; j < count; j++)
                    {
                        Console.Write(' ');
                    }
                    for (int j = i * 2 - 1; j > 0; j--)
                    {
                        rand = rnd.Next(0, 100);
                        if (rand < 10)
                            Console.Write('$');
                        else if (rand < 20)
                            Console.Write('@');
                        else if (rand < 30)
                            Console.Write('+');
                        else if (rand < 40)
                            Console.Write('(');
                        else if (rand < 50)
                            Console.Write(')');
                        else if (rand < 60)
                            Console.Write('=');
                        else if (rand < 70)
                            Console.Write('&');
                        else
                            Console.Write('*');
                    }
                    for (int j = i; j < count; j++)
                    {
                        Console.Write(' ');
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < count - 3; i++)
                {
                    Console.Write(' ');
                }
                for (int i = 0; i < 6; i++)
                {
                    Console.Write('|');
                }
                Console.WriteLine();

                }
            }
        }
    }


