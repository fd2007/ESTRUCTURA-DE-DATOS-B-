using System;
using System.Collections.Generic;

class TorresDeHanoi
{
    static void Main()
    {
        Console.WriteLine("Ingrese el número de discos:");
        int n = int.Parse(Console.ReadLine());

        // Crear tres torres como pilas
        Stack<int> origen = new Stack<int>();
        Stack<int> auxiliar = new Stack<int>();
        Stack<int> destino = new Stack<int>();

        // Inicializar la torre de origen con los discos
        for (int i = n; i >= 1; i--)
        {
            origen.Push(i);
        }

        Console.WriteLine("\nMovimientos necesarios para resolver las Torres de Hanoi:\n");
        ResolverHanoi(n, origen, destino, auxiliar, "Origen", "Destino", "Auxiliar");
    }

    /// <summary>
    /// Resuelve el problema de las Torres de Hanoi recursivamente.
    /// </summary>
    /// <param name="n">Número de discos</param>
    /// <param name="origen">Pila de origen</param>
    /// <param name="destino">Pila de destino</param>
    /// <param name="auxiliar">Pila auxiliar</param>
    /// <param name="nombreOrigen">Nombre de la torre de origen</param>
    /// <param name="nombreDestino">Nombre de la torre de destino</param>
    /// <param name="nombreAuxiliar">Nombre de la torre auxiliar</param>
    static void ResolverHanoi(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar,
                              string nombreOrigen, string nombreDestino, string nombreAuxiliar)
    {
        if (n == 1)
        {
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"Mover disco {disco} de {nombreOrigen} a {nombreDestino}");
            return;
        }

        // Mover n-1 discos de origen a auxiliar
        ResolverHanoi(n - 1, origen, auxiliar, destino, nombreOrigen, nombreAuxiliar, nombreDestino);

        // Mover el disco restante de origen a destino
        int discoGrande = origen.Pop();
        destino.Push(discoGrande);
        Console.WriteLine($"Mover disco {discoGrande} de {nombreOrigen} a {nombreDestino}");

        // Mover los n-1 discos de auxiliar a destino
        ResolverHanoi(n - 1, auxiliar, destino, origen, nombreAuxiliar, nombreDestino, nombreOrigen);
    }
}
