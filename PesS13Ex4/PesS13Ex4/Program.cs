using System;

namespace PesS13Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            while (contador <= 9)
            {
                int resultado; 
                contador++;
                resultado = contador * 5;
                Console.Write("\n" + contador + " x 5 = " + resultado);
            }
            Console.ReadKey();
        }
    }
}
