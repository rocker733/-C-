using System;

namespace Zadacha3
{
    class Program
    {
        static double distance(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x1");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите x2");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите y1");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
       
            Console.WriteLine($"Расстояние между точками:{distance(x1, x2, y1, y2):f2}");
            Console.ReadLine();
        }
    }
}
