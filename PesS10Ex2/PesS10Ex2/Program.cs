using System;

namespace PesS10Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um caracter alfanumerico: ");
            char alfan = char.Parse(Console.ReadLine());
            bool vogal = false, num = false, con = false;
            string[] vogais = new string[] { "a", "A", "e", "E", "i", "I", "o", "O", "u", "U" };
            string[] cons = new string[] { "b", "B", "c", "C", "d", "D", "f", "F", "g", "G", "h", "H", "j", "J", "k", "K", "l", "L", "m", "M", "p", "P", "q", "Q", "r", "R", "s", "S", "t", "T", "v", "V", "w", "W", "x", "X", "y", "Y", "z", "Z" };
            string[] nums = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            for (int i = 0; i < vogais.Length; i++)
            {
                if (vogais[i] == alfan.ToString())
                {
                    vogal = true;
                }
                else
                {
                    for (int x = 0; x < cons.Length; x++)
                    {
                        if (cons[x] == alfan.ToString())
                        {
                            con = true;
                        }
                        else
                        {
                            for (int y = 0; y < nums.Length; y++)
                            {
                                if (nums[y] == alfan.ToString())
                                {
                                    num = true;
                                }
                            }
                        }
                    }
                    
                }
            }
            if (vogal)
            {
                Console.WriteLine("é vogal");
            }
            else
            {
                if (con)
                {
                    Console.WriteLine("é consoante");
                }
                else
                {
                    if (num)
                    {
                        Console.WriteLine("é um numero");
                    }
                    else
                    {
                        Console.WriteLine("caracteres especiais");
                    }
                }
            }
        }
    }
}