using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

            int number1 = int.Parse(Console.Read());
            int number2 = int.Parse(Console.Read());
            int number3 = int.Parse(Console.ReadLine());
            int max = number1;

            if(number2 > number1)
                if(number2 > number3) max = number2;
                else max = number3;
            else if(number3 > number1) max = number3;

            Console.WriteLine("max = " + max);
            
        }
    }
}