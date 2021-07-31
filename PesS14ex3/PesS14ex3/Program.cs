using System;

namespace PesS14ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int mas = 0;
            int fem = 0;
            int alt = 0;
            int pes = 0;
            int soma = 0;
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
        
            while (nome != "@"){
                Console.WriteLine("Sexo(M/F)");
                string sexo = Console.ReadLine();
                Console.WriteLine("Peso");
                int peso = int.Parse(Console.ReadLine());
                Console.WriteLine("Altura");
                int altura = int.Parse(Console.ReadLine()); 
                Console.WriteLine("Idade");
                int idade = int.Parse(Console.ReadLine());
                if (sexo == "M"  ||  sexo == "m"){
                    mas = mas + 1;
                    if (alt < altura ||  mas == 1){
                        alt = altura;
                    }
                }
                if (sexo == "F" || sexo == "f") {
                    fem = fem + 1;
                    if(peso < pes | fem == 1){
                        pes = peso;
                    }
                }
                soma = soma + idade;
            }
            float media = soma / (mas + fem);
            Console.WriteLine("Altura do masculino: " + alt);
            Console.WriteLine("Peso do feminino: " + pes);
            Console.WriteLine("media de idade: " + media);
        }
    }
}
