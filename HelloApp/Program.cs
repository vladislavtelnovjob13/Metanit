﻿using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");
            string? name = Console.ReadLine();       // вводим имя
            Console.WriteLine($"Привет {name}");
        }
    }
}
