using System;
namespace lab_10
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cwiczenie 10");
            short sh = 1;
            ushort ush = 2;
            int i = 3;
            uint ui = 4;
            long l = 5;
            //niejawnea
            i = ush;
            l = ui;
            l = ush;
            ui = ush;
            //jawna
            sh = (short)l;
            i = (int)l;
            sh = (short)l;
            ush = (ushort)l;
        }
    }
}
 
