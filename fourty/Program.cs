using System;

namespace fourty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c");
            int c = Convert.ToInt32(Console.ReadLine());
            if (Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(c) < 0)
            {
                Console.WriteLine("Ошибка. Число не существует");
            }
            else
            {
                Console.WriteLine(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(c)));
            }
        }
    }
}
