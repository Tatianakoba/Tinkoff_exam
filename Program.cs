using System;


namespace Tinkoff_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два целых числа");
            int sum = 0;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            sum = a + b;
            Console.WriteLine(sum.ToString());
            Console.ReadKey();
        }
    }
}
