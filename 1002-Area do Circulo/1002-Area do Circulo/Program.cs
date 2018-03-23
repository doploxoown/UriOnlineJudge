using System;

namespace _1002_Area_do_Circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159, r;
            r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A=" + (pi * r * r).ToString("0.0000"));
            Console.ReadKey();
            
        }
    }
}
