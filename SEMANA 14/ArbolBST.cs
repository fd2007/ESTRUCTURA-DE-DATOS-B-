using System;

class ArbolBST
{
    public Nodo Raiz;

    // Insertar
    public Nodo Insertar(Nodo raiz, int valor)
    {
        if (raiz == null)
            return new Nodo(valor);

        if (valor < raiz.Valor)
            raiz.Izquierdo = Insertar(raiz.Izquierdo, valor);
        else if (valor > raiz.Valor)
            raiz.Derecho = Insertar(raiz.Derecho, valor);

        return raiz;
    }

    // Buscar
    public bool Buscar(Nodo raiz, int valor)
    {
        if (raiz == null)
            return false;

        if (valor == raiz.Valor)
            return true;

        if (valor < raiz.Valor)
            return Buscar(raiz.Izquierdo, valor);
        else
            return Buscar(raiz.Derecho, valor);
    }

    // Encontrar mínimo
    public Nodo MinimoNodo(Nodo nodo)
    {
        while (nodo.Izquierdo != null)
            nodo = nodo.Izquierdo;

        return nodo;
    }

    // Eliminar nodo
    public Nodo Eliminar(Nodo raiz, int valor)
    {
        if (raiz == null)
            return raiz;

        if (valor < raiz.Valor)
            raiz.Izquierdo = Eliminar(raiz.Izquierdo, valor);

        else if (valor > raiz.Valor)
            raiz.Derecho = Eliminar(raiz.Derecho, valor);

        else
        {
            if (raiz.Izquierdo == null)
                return raiz.Derecho;

            if (raiz.Derecho == null)
                return raiz.Izquierdo;

            Nodo temp = MinimoNodo(raiz.Derecho);
            raiz.Valor = temp.Valor;
            raiz.Derecho = Eliminar(raiz.Derecho, temp.Valor);
        }

        return raiz;
    }

    // Recorrido Inorden
    public void Inorden(Nodo raiz)
    {
        if (raiz != null)
        {
            Inorden(raiz.Izquierdo);
            Console.Write(raiz.Valor + " ");
            Inorden(raiz.Derecho);
        }
    }

    // Recorrido Preorden
    public void Preorden(Nodo raiz)
    {
        if (raiz != null)
        {
            Console.Write(raiz.Valor + " ");
            Preorden(raiz.Izquierdo);
            Preorden(raiz.Derecho);
        }
    }

    // Recorrido Postorden
    public void Postorden(Nodo raiz)
    {
        if (raiz != null)
        {
            Postorden(raiz.Izquierdo);
            Postorden(raiz.Derecho);
            Console.Write(raiz.Valor + " ");
        }
    }

    // Mínimo
    public int Minimo()
    {
        Nodo actual = Raiz;
        while (actual.Izquierdo != null)
            actual = actual.Izquierdo;

        return actual.Valor;
    }

    // Máximo
    public int Maximo()
    {
        Nodo actual = Raiz;
        while (actual.Derecho != null)
            actual = actual.Derecho;

        return actual.Valor;
    }

    // Altura
    public int Altura(Nodo nodo)
    {
        if (nodo == null)
            return -1;

        int izq = Altura(nodo.Izquierdo);
        int der = Altura(nodo.Derecho);

        return Math.Max(izq, der) + 1;
    }

    // Limpiar árbol
    public void Limpiar()
    {
        Raiz = null;
    }
}