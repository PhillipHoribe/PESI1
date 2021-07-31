using System;

namespace PesS13Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
        //Um:
            Console.WriteLine("Digite o primeiro valor: ");
            int um = int.Parse(Console.ReadLine());
        Dois:
            Console.WriteLine("Digite o segundo valor: ");
            int dois = int.Parse(Console.ReadLine());
            if (um < dois)
            {
                Console.WriteLine("O segundo é maior");
            }
            else {
                Console.Clear();
                Console.WriteLine("digite o segundo valor novamente");
                    goto Dois;
            }
        }
    }
}
