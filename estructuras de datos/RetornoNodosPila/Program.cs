
/*  crear una nueva pila, 
 *  agregar algunos elementos, 
 * imprimir el número de elementos en la pila 
 * imprimir el primer elemento de la pila 
 * imprimit si la pila está vacía o no y luego elimina los elementos uno por uno en un bucle.
 */



using System;
using System.Collections.Generic;

class Pila
{
    public Stack<int> stack = new Stack<int>();

    public int ObtenerPrimerElemento()
    {
        int primer = 0;
        foreach (int item in stack)
        {
            if (item == 10)
            {
                primer = item;
                break; // Detenemos el ciclo cuando encontramos el primer elemento
            }
        }
        return primer;
    }

    public int cantidadNodos()
    {
        //el .Count nos dice cuanto elementos/nodos contiene la pila.
        int cantidad = stack.Count;

        return cantidad;
    }

    public string verificarPila()
    {
        string aux = "";
        //en caso que .Count sea mayor a 0 la pila contiene elemento en caso contrario devolvera que la pila esta vacia
        if (stack.Count > 0)
        {
            aux = "la pila contiene elementos";
        }
        else
        {
            aux = "la pila esta vacia";
        }
        return aux;
    }

    static void Main(string[] args)
    {
        Pila pila = new Pila(); // Creamos una instancia de Program

        // Agregar elementos a la pila
        pila.stack.Push(10);
        pila.stack.Push(20);
        pila.stack.Push(30);

        // Imprimir los elementos de la pila
        Console.WriteLine("Elementos en la pila:");
        foreach (int item in pila.stack)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("El primer elemento es: " + pila.ObtenerPrimerElemento());

        Console.WriteLine("El primer elemento es: " + pila.cantidadNodos());

        Console.WriteLine("El primer elemento es: " + pila.verificarPila());


        // Sacar elementos de la pila
        Console.WriteLine("Elementos sacados de la pila:");
        while (pila.stack.Count > 0)
        {
            int item = pila.stack.Pop();
            Console.WriteLine(item);
        }
    }
}
