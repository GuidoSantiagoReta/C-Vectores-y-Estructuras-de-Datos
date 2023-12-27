

//Realizar un programa que permita administrar
//una lista tipo cola.
//Desarrollaremos los métodos de Insertar, Extraer, Vacia e Imprimir.

class Cola
{

    Queue<int> queue = new Queue<int>();

    public void agregarElemento(int elemento)
    {
        queue.Enqueue(elemento);    //enqueue metodo para agregar elemento
    }

    public void mostrarElementos()
    {
        Console.WriteLine("Elementos en la cola:");
        foreach (int item in queue)
        {
            Console.WriteLine(item);
        }
    }

    public void eliminarElementos()
    {
        Console.WriteLine("Elementos sacados de la cola:");
        while (queue.Count > 0)
        {
            int item = queue.Dequeue();  //Dequeue eliminar
            Console.WriteLine(item);
        }
    }

    public bool colaVacia()
    {
        return queue.Count == 0;
    }

}

class program
{
    static void Main(string[] args)
    {
        Cola cola = new Cola();

        cola.agregarElemento(1);
        cola.agregarElemento(2);
        cola.agregarElemento(3);

        cola.mostrarElementos();

        cola.eliminarElementos();

        cola.mostrarElementos();

        Console.ReadKey();
    }
}
