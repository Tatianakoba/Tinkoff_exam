

using System;


namespace _002_Contest2
{
    internal class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            double chet = N % 2;
            int bite = 1;
            int line = 1;
            
            if (N <= 1)
            {
                Console.WriteLine(line-1);
            }
            else if (chet == 0)
            {
                while (bite < (N-1))
                {
                    line += 1;
                    bite *= 2;
                }
                Console.WriteLine(line);
            }
            else
            {
                while (bite < (N-1))
                {
                    line += 1;
                    bite *= 2;
                }
                
                Console.WriteLine(line);
            }
            Console.ReadKey();

        }
    }
}
