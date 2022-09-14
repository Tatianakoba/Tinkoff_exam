//Результаты командной олимпиады за N лет. 
// В след N строках заданы команды-победиели. В каждой строке имена
//Вывод: Число - максимальное число побед команды в одинаковом составе.
using System;

namespace _002_exam
{
    internal class Program
    {
        static void Main()
        {
            
                var n = int.Parse(Console.ReadLine());
                var sortedNames = new string[n];
                for (var i = 0; i < n; i++)
                {
                    var names = Console.ReadLine().Split(' ');
                    Array.Sort(names);
                    var result = "";
                    for (var index = 0; index < names.Length; index++)
                    {
                        result += names[index];
                    }

                    sortedNames[i] = result;
                }

                int max = 0;

                for (var i = 0; i < sortedNames.Length; i++)
                {
                    var team = sortedNames[i];
                    var count = 0;
                    for (var j = 0; j < sortedNames.Length; j++)
                    {
                        if (team == sortedNames[j])
                        {
                            count++;
                        }
                    }

                    max = Math.Max(count, max);
                }

                Console.WriteLine(max);
            
            Console.ReadKey();

        }
    }
}
