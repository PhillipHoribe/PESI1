﻿using System;

namespace PesS06Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("B:");
            int b = int.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("Valores iguais");
            }
            else
            if (a > b)
            {
                Console.WriteLine("Valor B = " + b + " é o menor");
            }
            else
            {
                Console.WriteLine("Valor A = " + a + " é o menor");
            }
        }
    }
}
