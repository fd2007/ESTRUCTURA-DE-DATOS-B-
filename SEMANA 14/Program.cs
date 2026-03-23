using System;

class Program
{
    static void Main()
    {
        ArbolBST arbol = new ArbolBST();
        int opcion, valor;

        do
        {
            Console.WriteLine("\n===== MENU BST =====");
            Console.WriteLine("1. Insertar valor");
            Console.WriteLine("2. Buscar valor");
            Console.WriteLine("3. Eliminar valor");
            Console.WriteLine("4. Recorrido Inorden");
            Console.WriteLine("5. Recorrido Preorden");
            Console.WriteLine("6. Recorrido Postorden");
            Console.WriteLine("7. Valor minimo");
            Console.WriteLine("8. Valor maximo");
            Console.WriteLine("9. Altura del arbol");
            Console.WriteLine("10. Limpiar arbol");
            Console.WriteLine("0. Salir");

            Console.Write("Seleccione una opcion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese valor: ");
                    valor = int.Parse(Console.ReadLine());
                    arbol.Raiz = arbol.Insertar(arbol.Raiz, valor);
                    break;

                case 2:
                    Console.Write("Valor a buscar: ");
                    valor = int.Parse(Console.ReadLine());
                    if (arbol.Buscar(arbol.Raiz, valor))
                        Console.WriteLine("Valor encontrado");
                    else
                        Console.WriteLine("Valor no encontrado");
                    break;

                case 3:
                    Console.Write("Valor a eliminar: ");
                    valor = int.Parse(Console.ReadLine());
                    arbol.Raiz = arbol.Eliminar(arbol.Raiz, valor);
                    break;

                case 4:
                    Console.Write("Inorden: ");
                    arbol.Inorden(arbol.Raiz);
                    Console.WriteLine();
                    break;

                case 5:
                    Console.Write("Preorden: ");
                    arbol.Preorden(arbol.Raiz);
                    Console.WriteLine();
                    break;

                case 6:
                    Console.Write("Postorden: ");
                    arbol.Postorden(arbol.Raiz);
                    Console.WriteLine();
                    break;

                case 7:
                    Console.WriteLine("Minimo: " + arbol.Minimo());
                    break;

                case 8:
                    Console.WriteLine("Maximo: " + arbol.Maximo());
                    break;

                case 9:
                    Console.WriteLine("Altura: " + arbol.Altura(arbol.Raiz));
                    break;

                case 10:
                    arbol.Limpiar();
                    Console.WriteLine("Arbol eliminado");
                    break;
            }

        } while (opcion != 0);
    }
}