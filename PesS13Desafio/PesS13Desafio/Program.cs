using System;

namespace PesS13Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int soma = 0;
            while (contador <= 10)
            {
                soma += contador; 
            }
            Console.WriteLine("\nA soma de todos números é = " + soma);
            Console.ReadKey();
        }
    }
}
