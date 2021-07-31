using System;

namespace PesS07Ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o valor do peso:");
            int peso = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura:");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Sexo(F/M):");
            string sexo = Console.ReadLine();
            double altura1 = altura*altura;
            double relacao = peso/altura1;
            Console.Clear();
            Console.WriteLine("Sexo:" + sexo);
            switch (sexo) {
                case "F":
            if (relacao < 19)
            {
                Console.WriteLine("abaixo do peso");
            }
            else if (19 <= relacao & relacao < 24)
            {
                Console.WriteLine("peso ideal");
            }
            else
            {
                Console.WriteLine("acima do peso");
            }
                    break;
                case "M":
                    if (relacao < 19)
                    {
                        Console.WriteLine("abaixo do peso");
                    }
                    else if (19 <= relacao & relacao < 24)
                    {
                        Console.WriteLine("peso ideal");
                    }
                    else
                    {
                        Console.WriteLine("acima do peso");
                    }
                    break;
            }
        }
    }
}
