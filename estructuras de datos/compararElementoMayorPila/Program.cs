
/* 
- Crear una pila,  agrega tres números aleatorios y luego imprimir los elementos de la pila.
- Buscar e imprime el valor máximo en la pila. 
- eliminar todos los elementos de la pila e imprimirlos  

 */ 

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        // Agregar elementos a la pila
        int aux = int.MinValue;

        Random rand = new Random();
        stack.Push(rand.Next(0, 500));
        stack.Push(rand.Next(0, 500));
        stack.Push(rand.Next(0, 500));

        // Imprimir los elementos de la pila
        Console.WriteLine("Elementos en la pila:");

        //comparar elemento mayor en la pila
        foreach (int item in stack)
        {
            if (item > aux)
            {
                aux = item;
            }

        }
        Console.WriteLine(aux);

        /**/
        Console.WriteLine("Elementos sacados de la pila:");
        while (stack.Count > 0)
        {
            int item = stack.Pop();
            Console.WriteLine(item);
        }
    }

}
