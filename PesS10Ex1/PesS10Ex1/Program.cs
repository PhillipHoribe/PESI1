using System;

namespace PesS10Ex1
{
    class Program
    {
        static void Main(string[] args)
        {   codigo:
            Console.WriteLine("Salario Atual do Funcionario:");
            double salarioA = double.Parse(Console.ReadLine());
            double salarioB;
            if (salarioA < 0)
            {
                if (0 <= salarioA && salarioA < 500.00)
                {
                    salarioB = salarioA * 2;
                    Console.WriteLine("Salario Antigo: " + salarioA +
                         "\nReajuste: 100%" +
                         "\nSalario Final: " + salarioB);
                }
                else if (500 <= salarioA && salarioA < 1000)
                {
                    salarioB = salarioA + (salarioA * 0.75);
                    Console.WriteLine("Salario Antigo: " + salarioA +
                         "\nReajuste: 75%" +
                         "\nSalario Final: " + salarioB);
                }
                else if (1000 <= salarioA && salarioA < 1500)
                {
                    salarioB = salarioA + (salarioA * 0.5);
                    Console.WriteLine("Salario Antigo: " + salarioA +
                         "\nReajuste: 50%" +
                         "\nSalario Final: " + salarioB);
                }
                else if (1500 <= salarioA && salarioA < 2000)
                {
                    salarioB = salarioA + (salarioA * 0.25);
                    Console.WriteLine("Salario Antigo: " + salarioA +
                         "\nReajuste: 25%" +
                         "\nSalario Final: " + salarioB);
                }
                else if (2000 <= salarioA && salarioA < 3000)
                {
                    salarioB = salarioA + (salarioA * 0.1);
                    Console.WriteLine("Salario Antigo: " + salarioA +
                         "\nReajuste: 10%" +
                         "\nSalario Final: " + salarioB);
                }
                else if (3000 <= salarioA && salarioA < 5000)
                {
                    salarioB = salarioA + (salarioA * 0.05);
                    Console.WriteLine("Salario Antigo: " + salarioA +
                         "\nReajuste: 5%" +
                         "\nSalario Final: " + salarioB);
                }
                else
                {
                    salarioB = salarioA + (salarioA * 0.02);
                    Console.WriteLine("Salario Antigo: " + salarioA +
                         "\nReajuste: 2%" +
                         "\nSalario Final: " + salarioB);
                }
            }
            else
                Console.Clear();
                Console.WriteLine("error");
            goto codigo;
        }
    }
}
