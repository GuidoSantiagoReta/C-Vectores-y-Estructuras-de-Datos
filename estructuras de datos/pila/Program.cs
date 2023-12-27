
/*
- Crear una nueva pila de números enteros, 
- agregar algunos elementos, 
- imprimir el elemento superior de la pila y luego imprimir el número de elementos en la pila.

*/

using System;
using System.Collections.Generic;
using System.Linq;  

//clase pila generica
public class Pila<T>
{

    private Stack<T> pila = new Stack<T>();

    //agregar elemento a la pila
    public void Push(T item)
    {
        pila.Push(item);
    }
    //obtener el primer elemento sin eliminarlo
    public T Peek()
    {
        return pila.Peek();
    }

    //devuelve cantidad de elementos de la pila
    public int Count()
    {
        return pila.Count();
    }


    // IsEmpty método para determinar si hay elementos en la pila. El metodo Any devuelve true si la pila contiene al menos un elemento
    public bool IsEmpty()
    {
        return !pila.Any();
    }  

}

/*método main en una clase  Program  separada. 
 - Crea un objeto de la clase Pila  para números enteros 
 - coloca un número entero en la pila y luego imprime el elemento superior de la pila 
 -  método Peek para obtener el primer elemento sin eliminarlo. */
public class Program
{
    static void Main(string[] args)
    {
        Pila<int> pila = new Pila<int>();
        pila.Push(1);
        pila.Push(2);
        pila.Push(3);
        pila.Push(6);

        Console.WriteLine(pila.Peek());
        Console.WriteLine(pila.Count());
       

        
    }

  
}

