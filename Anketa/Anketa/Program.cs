using System;

namespace Anketa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваше имя:");
            var name = Console.ReadLine();

            Console.WriteLine("Ваша фамилия:");
            var surname = Console.ReadLine();

            Console.WriteLine("Ваш возраст");
            var age = Console.ReadLine();

            Console.WriteLine("Ваш рост:");
            var height = Console.ReadLine();

            Console.WriteLine("Ваш вес:");
            var weight = Console.ReadLine();

            //Конкретенация 
            //Console.WriteLine(name + " " + surname + " " + age + " " + height + " " + weight);

            //Составное форматирование
            //Console.WriteLine("{0}, {1}, {2}, {3}, {4}", name, surname, age, height, weight);

            //Интерполяция строк
            Console.WriteLine($"{name}, {surname}, {age}, {height}, {weight}");

            Console.ReadLine();
        }
    }
}
