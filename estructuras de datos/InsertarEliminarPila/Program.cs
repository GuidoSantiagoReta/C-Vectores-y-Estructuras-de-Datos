
/*Confeccionar una clase que administre una lista tipo
pila (se debe poder insertar, extraer e imprimir los datos de la pila)*/

class Pila
{
    Stack<int> stack = new Stack<int>();

    public void agregarElemento(int elemento)
    {
        stack.Push(elemento);
    }

    public void mostrarElementos()
    {
        Console.WriteLine("Elementos en la pila:");
        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }
    }

    public void eliminarElementos()
    {
        Console.WriteLine("Elementos sacados de la pila:");
        while (stack.Count > 0)
        {
            int item = stack.Pop();
            Console.WriteLine(item);
        }
    }

}

class program
{
    static void Main(string[] args)
    {
        Pila pila = new Pila();

        pila.agregarElemento(1);
        pila.agregarElemento(2);
        pila.agregarElemento(3);

        pila.mostrarElementos();

        pila.eliminarElementos();

        pila.mostrarElementos();

        Console.ReadKey();
    }
}
