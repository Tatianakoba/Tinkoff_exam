using System;


namespace _004_Contest1
{
    internal class Program
    {
        static void Main()
        {
            //получили строки
            var data = Console.ReadLine().Split(' ');
            //получили данные
            var n = int.Parse(data[0]);
            var operationCount = int.Parse(data[1]);

            //получили строки
            data = Console.ReadLine().Split(' ');

            //получили числа
            var numbers = new int[n];

            //нам нужен новый массив, чтобы класть туда эти числа, для этого нам нужен его размер
            var digitsCount = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(data[i]);
                digitsCount += data[i].Length;
            }

            //нам нужно получить массив изменений для каждой цифры, а для этого нужно разбить числа на разряды
            var digitsData = new int[digitsCount];
            var digitIndex = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                var number = numbers[i];
                var discharge = 1;
                while (number > 0)
                {
                    digitsData[digitIndex] = 9 * discharge - number % 10 * discharge;
                    digitIndex++;
                    discharge *= 10;
                    number /= 10;
                }
            }

            Array.Sort(digitsData);
            Array.Reverse(digitsData);

            var result = 0L;
            operationCount = Math.Min(operationCount, digitsData.Length);

            for (var i = 0; i < operationCount; i++)
            {
                result += digitsData[i];
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
