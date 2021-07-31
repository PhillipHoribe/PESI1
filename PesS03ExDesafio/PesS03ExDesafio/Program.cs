using System;

namespace PesS03ExDesafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do saque: ");
            int valor = int.Parse(Console.ReadLine());
            int n100 = valor / 100;
            int resto = valor - (n100 * 100); 
            int n50 = resto / 50;
            resto = resto - (n50 * 50);
            int n20 = resto / 20;
            resto = resto - (n20 * 20);
            int n10 = resto / 10;
            resto = resto - (n10 * 10);
            int n5 = resto / 5;
            resto = resto - (n5 * 5);
            int n2 = resto / 2;
            resto = resto - (n2 * 2);
            int n1 = resto / 1;
            resto = resto - (n1 * 1);
            Console.WriteLine();
            Console.WriteLine("Quantidade de notas:");
            Console.WriteLine("\nNotas de 100:  " +n100);
            Console.WriteLine("\nNotas de 50 :  " +n50);
            Console.WriteLine("\nNotas de 20 :  " +n20);
            Console.WriteLine("\nNotas de 10 :  " +n10);
            Console.WriteLine("\nNotas de 5  :  " +n5);
            Console.WriteLine("\nNotas de 2  :  " +n2);
            Console.WriteLine("\nNotas de 1  :  " +n1);
        }
    }
}
