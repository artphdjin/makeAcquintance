using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

            int N = int.Parse(Console.ReadLine());

            for(int i = 2; i<=N; i+=2){
                if(i != 2) Console.Write(", ");
                Console.Write(i);
            }
            
        }
    }
}