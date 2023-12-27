
/*
 - Obtener el Uúltimo elemento agregado a la pila usando
 - imprimir todos los elementos de la pila 
 - eliminar los elementos de la pila utilizando el método pop en un bucle while hasta que la pila esté vacía.

*/

using System;
using System.Collections.Generic;

class Pila
{
    public Stack<int> stack = new Stack<int>();

    static void Main(string[] args)
    {
        Pila pila = new Pila();

        // Agregar elementos a la pila
        pila.stack.Push(3);
        pila.stack.Push(7);
        pila.stack.Push(8);
        pila.stack.Push(6);
        pila.stack.Push(9);

        pila.ObtenerUltimoElemento();
    }

    public void ObtenerUltimoElemento()
    {
        int ultimo = stack.Peek(); 

        // Imprimir los elementos de la pila
        Console.WriteLine("Elementos en la pila:");
        foreach (int dato in stack)
        {
            Console.WriteLine(dato);
        }

        // Sacar elementos de la pila
        Console.WriteLine("Elementos sacados de la pila:");
        while (stack.Count > 0)
        {
            int item = stack.Pop();
            Console.WriteLine(item);
        }
    }
}
