using System;

namespace thirtyfour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите m");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите g");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(m*g*Math.Cos(a));
        }
    }
}
