using System;

namespace PesS13Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
        volta:
            Console.WriteLine("Digite o sexo:");
            string sexo = Console.ReadLine();
            if (sexo == "F" | sexo == "M")
            {
                Console.WriteLine("sexo valido");
            }
            else {
                goto volta;
            }
        }
    }
}
