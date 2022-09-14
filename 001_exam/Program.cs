using System;


namespace _001_exam
{
    internal class Program
    {
        static void Main()
        {
            int razn1 = 0;
            int razn2 = 0;
            double s = 0;

            var DataKoordinaty1 = Console.ReadLine().Split(' ');
            var x1 = int.Parse(DataKoordinaty1[0]);
            var y1 = int.Parse(DataKoordinaty1[1]);
            var x2 = int.Parse(DataKoordinaty1[2]);
            var y2 = int.Parse(DataKoordinaty1[3]);
            var DataKoordinaty2 = Console.ReadLine().Split(' ');
            var x3 = int.Parse(DataKoordinaty2[0]);
            var y3 = int.Parse(DataKoordinaty2[1]);
            var x4 = int.Parse(DataKoordinaty2[2]);
            var y4 = int.Parse(DataKoordinaty2[3]);

            if ((x1 < x3) && (x2 < x4))
            {
                razn1 = x4 - x1;
            }
            else if ((x3 < x1) && (x4 < x2))
            {
                razn1 = x2 - x3;
            }
            else if ((x1 < x3) && (x2 > x4))
            {
                razn1 = x2 - x1;
            }
            else if ((x3 < x1) && (x2 < x4))
            {
                razn1 = x4 - x3;

            }
            if ((y1 < y3) && (y2 < y4))
                {
                    razn2 = y4 - y1;
                }
            else if ((y3 < y1) && (y4 < y2))
                {
                    razn2 = y2 - y3;
                }
            else if ((y1 < y3) && (y2 > y4))
                {
                    razn2 = y2 - y1;
                }
            else if ((y3 < y1) && (y2 < y4))
                {
                    razn2 = y4 - y3;

                }

            if (razn1 < razn2)
            {
                s = Math.Pow(razn2, 2);
            }
            else
            {
                s = Math.Pow(razn1, 2);
            }

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
    }

