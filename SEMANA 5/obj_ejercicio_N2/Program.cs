using System;
using System.Collections.Generic;

class ProgramaNotas
{
    static void Main()
    {
        List<string> asignaturas = new List<string>
        {
            "Matemáticas", "Física", "Química", "Historia", "Lengua"
        };

        List<double> notas = new List<double>();

        foreach (var asignatura in asignaturas)
        {
            Console.Write($"Introduce la nota en {asignatura}: ");
            notas.Add(Double.Parse(Console.ReadLine() ?? "0"));
        }

        Console.WriteLine("\nResultados:");
        for (int i = 0; i < asignaturas.Count; i++)
        {
            Console.WriteLine($"En {asignaturas[i]} has sacado {notas[i]}");
        }
    }
}
