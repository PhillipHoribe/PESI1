using System;

namespace PesS13Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            teste:
            Console.WriteLine("Digite um numero:");
            int x = int.Parse(Console.ReadLine());
            if (x > 0)
            {
                goto teste;
            }
            else {
                Console.WriteLine("valor negativo");
            }
        }
    }
}
