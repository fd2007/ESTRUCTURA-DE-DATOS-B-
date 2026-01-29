using System;
using System.Collections.Generic;

namespace ParqueDiversiones
{
    // Clase Persona
    class Persona
    {
        public string Nombre { get; set; }
        public int Asiento { get; set; }

        public Persona(string nombre, int asiento)
        {
            Nombre = nombre;
            Asiento = asiento;
        }
    }

    // Clase Gestor de la Atracción
    class Atraccion
    {
        private Queue<Persona> cola;
        private int capacidadMaxima = 30;
        private int contadorAsientos = 0;

        public Atraccion()
        {
            cola = new Queue<Persona>();
        }

        // Método para agregar personas
        public void AgregarPersona(string nombre)
        {
            if (contadorAsientos < capacidadMaxima)
            {
                contadorAsientos++;
                Persona persona = new Persona(nombre, contadorAsientos);
                cola.Enqueue(persona);
                Console.WriteLine($"Persona {nombre} asignada al asiento #{contadorAsientos}");
            }
            else
            {
                Console.WriteLine("❌ La atracción está llena. No hay asientos disponibles.");
            }
        }

        // Reportería
        public void MostrarReporte()
        {
            Console.WriteLine("\n--- REPORTE DE ASIENTOS ---");

            if (cola.Count == 0)
            {
                Console.WriteLine("No hay personas registradas.");
            }
            else
            {
                foreach (var persona in cola)
                {
                    Console.WriteLine($"Nombre: {persona.Nombre} | Asiento: {persona.Asiento}");
                }
            }

            Console.WriteLine($"Asientos ocupados: {contadorAsientos}");
            Console.WriteLine($"Asientos disponibles: {capacidadMaxima - contadorAsientos}");
        }
    }

    // Clase Principal
    class Program
    {
        static void Main(string[] args)
        {
            Atraccion atraccion = new Atraccion();
            int opcion;

            do
            {
                Console.WriteLine("\n--- PARQUE DE DIVERSIONES ---");
                Console.WriteLine("1. Registrar persona");
                Console.WriteLine("2. Ver reporte");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el nombre de la persona: ");
                        string nombre = Console.ReadLine();
                        atraccion.AgregarPersona(nombre);
                        break;

                    case 2:
                        atraccion.MostrarReporte();
                        break;

                    case 3:
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != 3);
        }
    }
}
