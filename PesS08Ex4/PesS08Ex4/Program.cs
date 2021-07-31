using System;

namespace PesS08Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
        codigo:
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual a idade: ");
            int idade = int.Parse(Console.ReadLine());
            if (5 <= idade && idade <= 10) { 
                Console.WriteLine("" + nome + "Da Categoria Infantil");
            }
            else if (11 <= idade && idade <= 15)
            {
                Console.WriteLine("" + nome + "Da Categoria Juvenil");
            }
            else if (16 <= idade && idade <= 20)
            {
                Console.WriteLine("" + nome + "Da Categoria Junior");
            }
            else if (21 <= idade && idade <= 25)
            {
                Console.WriteLine(""+nome + "Da Categoria Profissional");
            }
            else {
                Console.Clear();
                Console.WriteLine("erro");
                goto codigo;
            }
        }
    }
}
