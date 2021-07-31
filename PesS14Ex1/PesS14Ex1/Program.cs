using System;

namespace PesS14Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int num, maior;
            Console.WriteLine("Digite o numero: ");
            num = int.Parse(Console.ReadLine());
            maior = num;


            for (i=1; i<9; i++){
                Console.WriteLine("Digite o numero: ");
                num = int.Parse(Console.ReadLine());
                maior = num;
                if (num > maior)
                {
                    maior = num;
                }
            }
            Console.WriteLine("maior numero =" + maior);
        }
    }
}
