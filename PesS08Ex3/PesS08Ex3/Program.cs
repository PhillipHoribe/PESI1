using System;

namespace PesS08Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
        codigo:
            Console.WriteLine("Digite o dia da semana:");
            int dia = int.Parse(Console.ReadLine());
            if (1<=dia && dia <=7)
            {
                switch (dia)
                {
                    case 1:
                        Console.WriteLine("O dia da semana é Domingo");
                        break;
                    case 2:
                        Console.WriteLine("O dia da semana é Segunda feira");
                        break;
                    case 3:
                        Console.WriteLine("O dia da semana é Terça feira");
                        break;
                    case 4:
                        Console.WriteLine("O dia da semana é Quarta feira");
                        break;
                    case 5:
                        Console.WriteLine("O dia da semana é Quinta Feira");
                        break;
                    case 6:
                        Console.WriteLine("O dia da semana é Sexta feira");
                        break;
                    case 7:
                        Console.WriteLine("O dia da semana é Sabado");
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Erro");
                goto codigo;
            }
        }
    }
}
