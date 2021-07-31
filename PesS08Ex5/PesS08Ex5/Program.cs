using System;

namespace PesS08Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            codigo:
            Console.WriteLine("Qual tipo de media deseja calcular?" +
                "\n 1-Aritimetica" +
                "\n 2-Ponderada(pesos:3,3,4)");
            int escolha = int.Parse(Console.ReadLine());
            Console.WriteLine("Nota 1: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota 2: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota 3: ");
            double nota3 = double.Parse(Console.ReadLine());
            double media;
            if (escolha == 1)
            {
                media = ((nota1 + nota2 + nota3) / 3);
                Console.WriteLine("A media Aritimetica é: " + media);
            }
            else if (escolha == 2) {
                media = (((nota1 * 3) + (nota2 * 3) + (nota3 * 4)) / 10);
                Console.WriteLine("A media Ponderada é: " + media);
            }
            else {
                Console.Clear();
                Console.WriteLine("Erro");
                goto codigo;
            }
        }
    }
}
