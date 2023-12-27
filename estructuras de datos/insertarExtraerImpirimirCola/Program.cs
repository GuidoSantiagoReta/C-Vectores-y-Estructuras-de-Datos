using System;
using System.Collections.Generic;

public class Cola
{
    Queue<int> queue = new Queue<int>();

    public void insertar(int item)
    {
        queue.Enqueue(item);
    }

    public void extraer()
    {
        Console.WriteLine("Elementos eliminados de la cola");
        while (queue.Count > 0)
        {
            int item = queue.Dequeue();
            Console.WriteLine(item);
        }
    }
    public bool vacia()
    {
        Console.WriteLine("La cola se encuentra:");
        return (queue.Count == 0);
    }

    public void imprimir()
    {
        Console.WriteLine("Elementos en la cola:");
        foreach (int item in queue)
        {
            Console.WriteLine(item);
        }
    }
}
class program
{
    static void Main(string[] args)
    {
        Cola cola = new Cola();
        cola.insertar(1);
        cola.insertar(2);
        cola.insertar(3);
        cola.imprimir();
        cola.imprimir();
        cola.imprimir();
        cola.extraer();
        cola.extraer();
        cola.extraer();


    }
}
