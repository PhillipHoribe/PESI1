using System;

namespace PesS03Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z,a;
            Console.WriteLine("x:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("y:");
            y = double.Parse(Console.ReadLine());
            z = x / y;
            a = x % y;
            Console.WriteLine("Quociente: " + z + "\nResto: " + a);
        }
    }
}
