using System;

namespace PesS03Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolar, qtd, final;
            
                Console.WriteLine("Valor do dolar");
            dolar = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor em dolar");
            qtd = double.Parse(Console.ReadLine());
            final = dolar * qtd;
            Console.WriteLine("Valor em reais:"+final);
        }
    }
}
