using System;


namespace _001_exam1
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

            int maximal1 = Math.Max(x2, x4);
            int minimal1 = Math.Min(x1, x3);
            razn1 = maximal1 - minimal1;
            int maximal2 = Math.Max(y2, y4);
            int minimal2 = Math.Min(y1, y3);
            razn2 = maximal2 - minimal2;
            s = Math.Pow(Math.Max(razn1, razn2),2);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
