using System;

namespace PesS06Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Base:");
            int bas = int.Parse(Console.ReadLine());
            Console.WriteLine("Altura:");
            int alt = int.Parse(Console.ReadLine());
            Console.Clear();
            int area = bas * alt;
            if (area > 100)
            {
                Console.WriteLine("Area grande : " + area);
            }
            else
            {
                Console.WriteLine("Area pequena: " + area);
            }
        }
    }
}
