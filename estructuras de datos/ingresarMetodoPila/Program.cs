using System;
using System.Collections.Generic;

/*Estructura de datos: Pila
 - Crear un programa que guarde números agregados
por el usuario hasta que introduzca "n", mostrar el numero mas alto ingresado.*/

class Pila
{
    public Stack <int> stack = new Stack<int>();
    static void Main(string[] args)
    {
        Pila pila = new Pila();

        while (true)
        {
            Console.WriteLine("Ingresar un numero, n para terminar: ");
            string teclado = Console.ReadLine();

            if (teclado == "n")
            {
                break;
            }

            int numero;
            //Si la entrada es un número, convertir a entero.
            if (int.TryParse(teclado, out numero))   
            {
                pila.stack.Push(numero);
            }

            else
            {
                Console.WriteLine("Error, ingrese un numero valido o n para terminar");
            }
        }

        int maximo = 0;
        foreach (int numero in pila.stack)
        {
            if (numero > maximo)
            {
                maximo = numero;
            }
        }
        Console.WriteLine("El numero mas alto ingresado es: " + maximo);
    }
}