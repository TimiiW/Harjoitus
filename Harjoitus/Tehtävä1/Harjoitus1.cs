
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //laskeYhteen(3, 5);
            Tehtava2(10, 35);

        }
        public static void laskeYhteen(int luku1, int luku2)
        {
            Console.WriteLine(luku1 + luku2);
        }

        public static void Tehtava2(int luku1, int luku2)
        {
            laske(luku1, luku2);
        }
        public static void laske(int luku1, int luku2)
        {
            Console.WriteLine((luku1 + luku2) * 1.8);
        }
    }
}
