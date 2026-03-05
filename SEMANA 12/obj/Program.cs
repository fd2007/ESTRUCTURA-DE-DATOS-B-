using System;
using System.Collections.Generic;

namespace BibliotecaApp
{
    class Libro
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Anio { get; set; }
        public string Categoria { get; set; }

        public Libro(string isbn, string titulo, string autor, int anio, string categoria)
        {
            ISBN = isbn;
            Titulo = titulo;
            Autor = autor;
            Anio = anio;
            Categoria = categoria;
        }

        public void MostrarLibro()
        {
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Autor: " + Autor);
            Console.WriteLine("Año: " + Anio);
            Console.WriteLine("Categoría: " + Categoria);
            Console.WriteLine("---------------------------");
        }
    }

    class Program
    {
        static Dictionary<string, Libro> biblioteca = new Dictionary<string, Libro>();
        static HashSet<string> categorias = new HashSet<string>();

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("===== SISTEMA DE BIBLIOTECA =====");
                Console.WriteLine("1. Registrar libro");
                Console.WriteLine("2. Consultar libro por ISBN");
                Console.WriteLine("3. Mostrar todos los libros");
                Console.WriteLine("4. Eliminar libro");
                Console.WriteLine("5. Mostrar categorías");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        RegistrarLibro();
                        break;

                    case 2:
                        ConsultarLibro();
                        break;

                    case 3:
                        MostrarLibros();
                        break;

                    case 4:
                        EliminarLibro();
                        break;

                    case 5:
                        MostrarCategorias();
                        break;

                    case 6:
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }

            } while (opcion != 6);
        }

        static void RegistrarLibro()
        {
            Console.Write("Ingrese ISBN: ");
            string isbn = Console.ReadLine();

            if (biblioteca.ContainsKey(isbn))
            {
                Console.WriteLine("Este libro ya está registrado.");
                return;
            }

            Console.Write("Ingrese título: ");
            string titulo = Console.ReadLine();

            Console.Write("Ingrese autor: ");
            string autor = Console.ReadLine();

            Console.Write("Ingrese año: ");
            int anio = int.Parse(Console.ReadLine());

            Console.Write("Ingrese categoría: ");
            string categoria = Console.ReadLine();

            Libro nuevoLibro = new Libro(isbn, titulo, autor, anio, categoria);

            biblioteca.Add(isbn, nuevoLibro);
            categorias.Add(categoria);

            Console.WriteLine("Libro registrado correctamente.");
        }

        static void ConsultarLibro()
        {
            Console.Write("Ingrese ISBN del libro: ");
            string isbn = Console.ReadLine();

            if (biblioteca.ContainsKey(isbn))
            {
                biblioteca[isbn].MostrarLibro();
            }
            else
            {
                Console.WriteLine("Libro no encontrado.");
            }
        }

        static void MostrarLibros()
        {
            if (biblioteca.Count == 0)
            {
                Console.WriteLine("No hay libros registrados.");
                return;
            }

            foreach (var libro in biblioteca.Values)
            {
                libro.MostrarLibro();
            }
        }

        static void EliminarLibro()
        {
            Console.Write("Ingrese ISBN del libro a eliminar: ");
            string isbn = Console.ReadLine();

            if (biblioteca.Remove(isbn))
            {
                Console.WriteLine("Libro eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("Libro no encontrado.");
            }
        }

        static void MostrarCategorias()
        {
            Console.WriteLine("Categorías registradas:");

            foreach (var categoria in categorias)
            {
                Console.WriteLine("- " + categoria);
            }
        }
    }
}