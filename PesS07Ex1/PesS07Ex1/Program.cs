using System;

namespace PesS07Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do peso:");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura:");
            double altura = double.Parse(Console.ReadLine());
            double relacao = peso / (altura * altura);
            if (relacao < 20)
            {
                Console.WriteLine("abaixo do peso");
            }
            else if (20 <= relacao & relacao < 25)
            {
                Console.WriteLine("peso ideal");
            }
            else {
                Console.WriteLine("acima do peso");
            }
        }
    }
}
