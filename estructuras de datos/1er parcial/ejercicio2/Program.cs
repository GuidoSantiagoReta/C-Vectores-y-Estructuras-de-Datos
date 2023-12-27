using System;
using System.Collections.Generic;

// MENU CON COLA E INGRESO DE ELEMENTOS
class Program
{
    static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>();

        int elegir;

        do
          {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. agregar elemento a la cola");
            Console.WriteLine("2. eliminar elemento de la cola");
            Console.WriteLine("3. Mostrar");
            Console.WriteLine("4. Exit");

            Console.Write("elegir opcion: ");

            //convertir string a numero
            elegir = int.Parse(Console.ReadLine());

            switch (elegir)
            {
                case 1:
                    Console.Write("Introducir el elemento a agregar: ");
                    int item = int.Parse(Console.ReadLine());
                    queue.Enqueue(item);
                    Console.WriteLine("Se agrego el elemento: " + item);
                    break;

                case 2:
                    if (queue.Count > 0)
                    {
                        int eliminar = queue.Dequeue();
                        Console.WriteLine("eliminar elemento " + eliminar);
                    }
                    else
                    {
                        Console.WriteLine("La cola se encuetra vacia");
                    }
                    break;
                case 3:
                    Console.WriteLine("Elementos en la cola: ");
                    foreach (var elemento in queue)
                    {
                        Console.WriteLine(elemento);
                    }
                    break;
                case 4:
                    Console.WriteLine("salir del programa");
                    return;
                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;
            }

            Console.WriteLine();
        } while (elegir != 4);
    }
}