using System;

namespace PesS08Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
             codigo:
            Console.WriteLine("Digite o estado civil:");
            String estado = Console.ReadLine();
            string primeira = estado[0].ToString();
            if (primeira == "S" || primeira == "C" || primeira == "V" || primeira == "D" || primeira == "s" || primeira == "c" || primeira == "v" || primeira == "d")
            {
                switch (primeira)
                {
                    case "S":
                        Console.WriteLine("O Estado Civil é Solteiro");
                        break;
                    case "C":
                        Console.WriteLine("O Estado Civil é Casado");
                        break;
                    case "V":
                        Console.WriteLine("O Estado Civil é Viuvo");
                        break;
                    case "D":
                        Console.WriteLine("O Estado Civil é Divorciado");
                        break;
                    case "s":
                        Console.WriteLine("O Estado Civil é Solteiro");
                        break;
                    case "c":
                        Console.WriteLine("O Estado Civil é Casado");
                        break;
                    case "v":
                        Console.WriteLine("O Estado Civil é Viuvo");
                        break;
                    case "d":
                        Console.WriteLine("O Estado Civil é Divorciado");
                        break;
                }
            }
            else {
                Console.Clear();
                Console.WriteLine("Erro");
                goto codigo;
            }
        }
    }
}
