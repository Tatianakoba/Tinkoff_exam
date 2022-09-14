using System;

namespace Var2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите два целых числа");
            int sum = 0;
            short a = short.Parse(Console.ReadLine());
            short b = short.Parse(Console.ReadLine());
            sum = a + b;
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
