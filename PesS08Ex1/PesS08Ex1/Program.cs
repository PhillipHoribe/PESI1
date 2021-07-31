using System;

namespace PesS08Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            codigo :
            Console.WriteLine("Digite um mês de 1-12: ");
            int mes = int.Parse(Console.ReadLine());
            if (1 <= mes && mes <= 12)
            {
                switch (mes)
                {
                    case 1:
                        Console.WriteLine("A estação do ano correspondente ao mês " + mes + " é Verão");
                        break;
                    case 2:
                        Console.WriteLine("A estação do ano correspondente ao mês " + mes + " é Verão");
                        break;
                    case 3:
                        Console.WriteLine("A estação do ano correspondente ao mês " + mes + " é Verão");
                        break;
                    case 4:
                        Console.WriteLine("A estação do ano correspondente ao mês " + mes + " é Outono");
                        break;
                    case 5:
                        Console.WriteLine("A estação do ano correspondente ao mês " + mes + " é Outono");
                        break;
                    case 6:
                        Console.WriteLine("A estação do ano correspondente ao mês " + mes + " é Outono");
                        break;
                    case 7:
                        Console.WriteLine("A estação do ano correspondente ao mês " + mes + " é Inverno");
                        break;
                    case 8:
                        Console.WriteLine("A estação do ano correspondente ao mês " + mes + " é Inverno");
                        break;
                    case 9:
                        Console.WriteLine("A estação do ano correspondente ao mês " + mes + " é Inverno");
                        break;
                    case 10:
                        Console.WriteLine("A estação do ano correspondente ao mês " + mes + " é Primavera");
                        break;
                    case 11:
                        Console.WriteLine("A estação do ano correspondente ao mês " + mes + " é Primavera");
                        break;
                    case 12:
                        Console.WriteLine("A estação do ano correspondente ao mês " + mes + " é Primavera");
                        break;
                }
            }
                else
                {
                Console.Clear();
                goto codigo;
                }
            }
        }
    }
