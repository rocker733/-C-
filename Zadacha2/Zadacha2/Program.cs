using System;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш вес");
            string m = Console.ReadLine();

            Console.WriteLine("Введите ваш рост");
            string h = Console.ReadLine();
            double s = Convert.ToDouble(m);
            double ss = Convert.ToDouble(h);
            var I = s / (ss * ss);

            Console.WriteLine("Индекс массы тела: " + I);
        }
    }
}
