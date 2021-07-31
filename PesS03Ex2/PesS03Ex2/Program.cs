using System;

namespace PesS03Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sal, perc, final;

            Console.WriteLine("Salario atual");
            sal = double.Parse(Console.ReadLine());
            Console.WriteLine("Percentual de reajuste");
            perc = double.Parse(Console.ReadLine());
            final = sal + (sal * (perc/100));
            Console.WriteLine("Salario Final:" + final);
        }
    }
}
