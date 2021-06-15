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
            int God = 2021;
            Console.WriteLine("Введите свой год рождения: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Name: Hello {name + lastname}! " +
                $"Your age is Age: {Age = God - age}");

          

            Console.ReadKey();

        }

            

    }
    
}
