using System;

namespace twentytwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Pow(Math.E, x)-x-2+Math.Pow(1+x, x));
        }
    }
}
