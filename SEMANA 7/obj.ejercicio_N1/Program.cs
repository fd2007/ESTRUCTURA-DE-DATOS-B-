using System;
using System.Collections.Generic;

class ParentesisBalanceados
{
    /// <summary>
    /// Método principal que solicita la expresión y verifica si está balanceada.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Ingrese una expresión matemática:");
        string expresion = Console.ReadLine();

        if (EstaBalanceada(expresion))
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula NO balanceada.");
    }

    /// <summary>
    /// Verifica si los paréntesis, llaves y corchetes de la expresión están balanceados.
    /// </summary>
    /// <param name="expresion">Cadena con la expresión matemática</param>
    /// <returns>True si está balanceada, false si no</returns>
    static bool EstaBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char caracter in expresion)
        {
            if (caracter == '(' || caracter == '{' || caracter == '[')
            {
                pila.Push(caracter); // Agrega el símbolo de apertura a la pila
            }
            else if (caracter == ')' || caracter == '}' || caracter == ']')
            {
                if (pila.Count == 0) return false; // No hay apertura correspondiente

                char ultimo = pila.Pop(); // Extrae el último símbolo de apertura

                // Verifica que cierre corresponda a la apertura
                if (!((ultimo == '(' && caracter == ')') ||
                      (ultimo == '{' && caracter == '}') ||
                      (ultimo == '[' && caracter == ']')))
                {
                    return false;
                }
            }
        }

        return pila.Count == 0; // Si la pila está vacía, todo está balanceado
    }
}
