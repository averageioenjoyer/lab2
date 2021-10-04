using System;

namespace twentyeight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter f");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter d");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter z");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y");
            int y = Convert.ToInt32(Console.ReadLine());
            if (Math.Sin(x) == 0)
            {
                Console.WriteLine("Ошибка. Деление на ноль");
            }
            else if (d * Math.Pow(x, 3) - f == 0)
            {
                Console.WriteLine("Ошибка. Деление на ноль");
            }
            else
            {
                Console.WriteLine((Math.Pow(Math.Cos(x), 2)) / Math.Sin(x) - x * y * z + (a * Math.Pow(x, 2) + b * x + c) / (d * Math.Pow(x, 3) - f));            
            }
        }
    }
}
