
//ESTRUCTURA DE DATOS COLAS: LOS DATOS VAN SALIENDO CONFORME VAN LLEGANDO COMO UNA COLA DE SUPERMERCADO, EL PRIMERO QUE ENTRA VA A A SER EL PRIMERO QUE SALE

using System;
using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        //creando el objeto
        Queue miFila = new Queue();
        //agregando datos a la fila
        miFila.Enqueue("Juan");
        miFila.Enqueue("Roberto");
        miFila.Enqueue("Matias");

        Console.WriteLine(miFila.Count);  //devuelve los clientes antes de desencolarlos

        for (int cont = 0; cont < 3; cont++)
        {
            Console.WriteLine("el empleado atiende a:" +miFila.Dequeue());  //el metodo Dequeue para desencolar
        }
        Console.WriteLine(miFila.Count);   //devuelve la cantidad de la fila = 0 porque ya atendieron a los clientes


    }
}