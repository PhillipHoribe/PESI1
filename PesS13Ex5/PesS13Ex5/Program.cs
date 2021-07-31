using System;

namespace PesS13Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            teste:
            Console.WriteLine("Digite um valor: ");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                while (contador <= 9)
                {
                    int resultado;
                    contador++;
                    resultado = contador * num;
                    Console.Write("\n" + contador + " x " + num + " = " + resultado);
                }
                Console.ReadKey();
            }
            else {
                Console.WriteLine("valor invalido");
                goto teste;
            }
        }
    }
}
