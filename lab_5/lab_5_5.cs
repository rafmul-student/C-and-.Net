using System;
using System.Runtime.InteropServices;
namespace lab_5
{
    class Program
    {
        [DllImport("msvcrt.dll")]
        public static extern int puts(string c);
        [DllImport("msvcrt.dll")]
        public static extern int _flushall();
        static void Main(string[] args)
        {
            string s = "Jakis tutaj napis";
            puts(s);
            _flushall();
        }
    }
}
