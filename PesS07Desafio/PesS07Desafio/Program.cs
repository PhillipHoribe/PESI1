using System;

namespace PesS07Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A-alcool ou G-gasolina");
            string opcao = Console.ReadLine();
            switch (opcao) {
                case "A":
                    Console.WriteLine("Quantos litros de Alcool:");
                    int alcool = int.Parse(Console.ReadLine());
                    double valorAlcool=1.90, valorPagar,;
                    if (alcool <= 25)
                    {
                        valorPagar = alcool * (valorAlcool * 0.02);
                        Console.WriteLine("Valor a pagar: " + valorPagar);
                    }
                    else if (alcool > 25)
                    {
                        valorPagar = alcool * (valorAlcool * 0.04);
                        Console.WriteLine("Valor a pagar: " + valorPagar);
                    }
                    else {
                        valorPagar = alcool * valorAlcool;
                        Console.WriteLine("Valor a pagar: " + valorPagar);
                    }
                    break;
                case "G":
                    Console.WriteLine("Quantos litros de Gasolina:");
                    int gasolina = int.Parse(Console.ReadLine());
                    double valorPagar1, valorGasolina= 2.70;
                    if (gasolina <= 25)
                    {
                        valorPagar1 = gasolina * (valorGasolina * 0.03);
                        Console.WriteLine("Valor a pagar: " + valorPagar1);
                    }
                    else if (gasolina > 25)
                    {
                        valorPagar1 = gasolina * (valorGasolina * 0.05);
                        Console.WriteLine("Valor a pagar: " + valorPagar1);
                    }
                    else
                    {
                        valorPagar1 = gasolina * valorGasolina;
                        Console.WriteLine("Valor a pagar: " + valorPagar1);
                    }
                    break;
            }
        }
    }
}
