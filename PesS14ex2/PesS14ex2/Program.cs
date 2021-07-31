using System;

namespace PesS14ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior, num = 1;
            
            Console.WriteLine("numero: ");
            num = int.Parse(Console.ReadLine());
            maior = num;
            while (num != 0)
            {
                Console.WriteLine("numero: ");
                num = int.Parse(Console.ReadLine());
                if (num > maior) {
                    maior = num;
                }
            }
            Console.WriteLine("Maior: " + maior);
        }
    }       
}
