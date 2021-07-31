using System;

namespace PesS10Ex3
{
    class Program
    {
        static void Main(string[] args)
        {   codigo:
            Console.WriteLine("Digite um numero:");
            double num = double.Parse(Console.ReadLine());
            double resultado;
            Console.WriteLine("1-Raiz Quadrada"+
                            "\n2-10% do numero"+
                            "\n3-O dobro"+
                            "\nEscolha a opção:");
            int opcao = int.Parse(Console.ReadLine());
            if (0 < opcao && opcao < 4)
            {
                switch (opcao)
                {
                    case 1:
                        resultado = (num * num);
                        Console.Clear();
                        Console.WriteLine("Numero: " + num +
                       "\nResultado: " + resultado);
                        break;
                    case 2:
                        resultado = (num * 0.1);
                        Console.Clear();
                        Console.WriteLine("Numero: " + num +
                       "\nResultado: " + resultado);
                        break;
                    case 3:
                        resultado = (num * 2);
                        Console.Clear();
                        Console.WriteLine("Numero: " + num +
                       "\nResultado: " + resultado);
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opcao invalida!");
                goto codigo;
            }
        }
    }
}
