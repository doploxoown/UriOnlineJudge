﻿using System;

namespace _1001_Extremamente_Básico
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            x = a + b;

            Console.WriteLine("X = " + x);

            Console.ReadKey();
        }
    }
}
