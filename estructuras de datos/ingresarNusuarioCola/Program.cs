// Ejercicio: ingresar numeros a la cola y calcular el promedio.

using System;
using System.Collections.Generic;
using System.Linq;

public class Cola
{
    Queue<int> queue = new Queue<int>();
   static void Main(string[] args)
    {
        Cola cola = new Cola();

        while (true)
        {
            Console.WriteLine("Ingrese un numero, para termina presione n");
            string teclado = Console.ReadLine();

            if (teclado == "n")
            {
                break;
            }

            int numero;
            if (int.TryParse(teclado, out numero))
            {
                cola.queue.Enqueue(numero);
            } 
            else
            {
                Console.WriteLine("Error, ingrese un numero valido o n para terminar: ");
            }
        }
        //promedio de los numeros ingresados por teclado
        double promedio = cola.queue.Average();
        Console.WriteLine("El promedio de los numeros ingresados es: " + promedio);
     
  }

}
