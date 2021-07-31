using System;

namespace PesS07Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prova 1:");
            double prova1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Prova 2:");
            double prova2 = double.Parse(Console.ReadLine());
            double media = (prova1 + (2 * prova2)) / 3;
            Console.WriteLine("A media é: " + media);
        }
    }
}
