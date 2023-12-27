using System;
using System.Collections;

//PILAS: EL PRIMER DATO EN SALIR VA A SER EL PRIMERO QUE LLEGO


class Program
{
  static void Main(string[]args)
    { 
        //creando la pila
        Stack pilaDeDatos = new Stack();

        //agregando datos a la pila
        pilaDeDatos.Push("Juan");
        pilaDeDatos.Push("Raul");
        pilaDeDatos.Push("Romina");

        // imprimiendo el valor de datos que contiene la pila
        Console.WriteLine(pilaDeDatos.Count);
        // creando la variable para contar los datos de la pila
        int tamPila = pilaDeDatos.Count;

        for (int cont = 0; cont < tamPila; cont++)
        {  
            //sacando los valores de  la pila desde el ultimo  valor que ingreso a la pila
            Console.WriteLine("Valores de la pila: " + pilaDeDatos.Pop());
        }
    }
    
}