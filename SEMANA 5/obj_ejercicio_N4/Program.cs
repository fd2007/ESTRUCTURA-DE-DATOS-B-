using System;
using System.Collections.Generic;
using System.Linq;

class Loteria
{
    static void Main()
    {
        List<int> ganadores = new List<int>();
        Console.WriteLine("Introduce 6 números de la lotería:");

        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Número {i + 1}: ");
            ganadores.Add(int.Parse(Console.ReadLine() ?? "0"));
        }

        ganadores.Sort();

        Console.WriteLine("\nNúmeros ganadores (ordenados):");
        ganadores.ForEach(n => Console.Write($"{n} "));
    }
}
