using System;

namespace Zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            // обмен значениями с использованием третьей переменной
            int a = 5;
            int b = 6;
            int temp = 5;
            a = b;
            b = temp;
            

            /*обмен значениями без использования третьей переменной
            int a = 5;
            int b = 6;
            (a, b) = (b, a);
            */

            /*
            int a = 5;
            int b = 6;

            a = a + b;
            b = b - a;
            b = -b;
            a = a - b;
            */
            Console.WriteLine((a, b));
        }
    }
}
