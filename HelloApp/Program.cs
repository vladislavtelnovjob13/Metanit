using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");
            string? name = Console.ReadLine();       // вводим имя
            Console.WriteLine($"Привет {name}");
            Console.ReadLine();
            TRUETH(name);
        }

        static void TRUETH( string a)
        {
            string name = "Tom";
            int age = 34;
            double height = 1.7;
            Console.WriteLine($"Имя: {name}  \nВозраст: {age}  \nРост: {height}м");
        }
    }
}
