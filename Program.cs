using System;

class Estudiante
{
    // Atributos de la clase
    public int ID;
    public string Nombres;
    public string Apellidos;
    public string Direccion;

    // Arreglo para almacenar 3 números de teléfono
    public string[] Telefonos = new string[3];

    // Método para mostrar los datos
    public void MostrarDatos()
    {
        Console.WriteLine("\n--- Información del Estudiante ---");
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Apellidos: {Apellidos}");
        Console.WriteLine($"Dirección: {Direccion}");
        Console.WriteLine("Teléfonos:");

        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.WriteLine($"Teléfono {i + 1}: {Telefonos[i]}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear objeto estudiante
        Estudiante est = new Estudiante();

        Console.WriteLine("Registro de Estudiante\n");

        // Captura de datos
        Console.Write("Ingrese el ID: ");
        est.ID = int.Parse(Console.ReadLine());

        Console.Write("Ingrese los nombres: ");
        est.Nombres = Console.ReadLine();

        Console.Write("Ingrese los apellidos: ");
        est.Apellidos = Console.ReadLine();

        Console.Write("Ingrese la dirección: ");
        est.Direccion = Console.ReadLine();

        // Captura de los 3 números de teléfono
        Console.WriteLine("\nIngrese los 3 números de teléfono:");
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Teléfono {i + 1}: ");
            est.Telefonos[i] = Console.ReadLine();
        }

        // Mostrar resultados
        est.MostrarDatos();

        Console.WriteLine("\nProceso finalizado.");
    }
}

