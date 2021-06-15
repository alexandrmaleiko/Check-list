using System;

namespace ComputerScience
{
    class Program
    {
        static void Main(string[] args) {

            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            string lastname = Console.ReadLine();

            int Age;
            int year = 2021;
            Console.Write("Введите свой год рождения: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Name: Hello {name + lastname}! " +
                $"Your age is Age: {Age = year - age}");

          

            Console.ReadKey();

        }

            

    }
    
}
