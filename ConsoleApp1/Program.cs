using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Tom";
            int age = 33;
            bool isEmployed = false;
            double height = 1.87;

            Console.WriteLine("Имя: {0}  Возраст: {2}  Рост: {1}м", name, height, age);

            Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м");

            Console.Write("Введите имя: ");
            string name1 = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int age1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Имя: {name1}");

            Console.ReadKey();
        }
    }
}
