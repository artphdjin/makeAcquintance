using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine((number1 % 2 == 0) ? "да" : "нет");
            
        }
    }
}