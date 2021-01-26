using System;

namespace Zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Никита";
            string surname = "Игнашов";
            string city = "Москва";

            string info = ($"Ваши данные: {name}, {surname}, {city}");

            // вывод строки в цетрне экрана
            int centerX = (Console.WindowWidth / 2) - (info.Length / 2);
            int centerY = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX, centerY);
            Console.Write(info);
        }
    }
}
