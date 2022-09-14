using System;
//У Кости есть бумажка, на которой написано ﻿﻿nn﻿﻿ чисел. Также у него есть возможность не больше,
//чем ﻿﻿kk﻿﻿ раз, взять любое число с бумажки, после чего закрасить одну из старых цифр,
//а на ее месте написать новую произвольную цифру.

//На какое максимальное значение Костя сможет увеличить сумму всех чисел на листочке?



//Формат входных данных

//В первой строке входного файла даны два целых числа ﻿﻿n, kn, k﻿﻿ — количество чисел на бумажке и ограничение на число операций. 

//﻿﻿(1\leq n \leq 1000, 1 \leq k \leq 10^4)(1≤n≤1000,1≤k≤10
//4
// )﻿﻿ .

//Во второй строке записано ﻿﻿nn﻿﻿ чисел ﻿﻿a_ia 
//i
//​
// ﻿﻿ — числа на бумажке ﻿﻿(1 \leq a_i \leq 10^9)(1≤a
//i
//​
// ≤10 
//9
// )﻿﻿



//Формат выходных данных 

//В выходной файл выведите одно число — максимальную разность между конечной и начальной суммой.



namespace _004_Contest
{
    internal class Program
    {
        static void Main()
        {
            var DataVvod = Console.ReadLine().Split(' '); //количество чисел и ограничение по количеству операций
            int amountnum = int.Parse(DataVvod[0]);
            int Transact = int.Parse(DataVvod[1]);
            string[] DataNumbers = Console.ReadLine().Split(' '); //массив чисел a(i)
            
            int[] Numbers = new int[amountnum]; //пустой массив для записи чисел
            int Index = 0;
            for (int i = 0; i < Numbers.Length; i++)
            {
                var number = Numbers[i];
                var discharge = 1;
                while (number > 0)
                {
                    Numbers[Index] = 9 * discharge - number % 10 * discharge;
                    Index++;
                    discharge *= 10;
                    number /= 10;
                }
            }
            Array.Sort(Numbers);
            Array.Reverse(Numbers);
            var result = 0L;
            Transact = Math.Min(Transact, Numbers.Length);

            for (var i = 0; i < Transact; i++)
            {
                result += Numbers[i];
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
