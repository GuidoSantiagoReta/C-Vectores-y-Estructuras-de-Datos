using System;
using System.Collections.Generic;


/// MENU PARA AGREGAR, ELIMINAR Y MOSTRAR ELEMENTOS DE UNA PILA
class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();

        int elegir;

        do
        {
                Console.WriteLine("Menu: ");
                Console.WriteLine("1. agregar elemento a la pila: ");
                Console.WriteLine("2. eliminar elemento de la pila: ");
                Console.WriteLine("3. Mostrar: ");
                Console.WriteLine("4. Exit");

                Console.Write("elegir opcion: ");

               //convertir string a numero
                elegir = int.Parse(Console.ReadLine());

                switch (elegir)
                {
                    case 1:
                        Console.Write("ingresar numero para agregar a la pila: ");
                        int agregar = int.Parse(Console.ReadLine());
                        stack.Push(agregar);
                    break;

                    case 2:
                        if (stack.Count > 0)
                        {
                            int eliminar = stack.Pop();
                            Console.WriteLine("eliminar numero " + eliminar);
                        }
                        else
                        {
                            Console.WriteLine("La pila se encuetra vacia");
                        }
                        break;
                    case 3:
                        if (stack.Count > 0)
                        {
                            int numeroMayor = stack.Max();
                            Console.WriteLine("Numero superior: " + numeroMayor);
                        }
                        else
                        {
                            Console.WriteLine("la pila se encuetra vacia");
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




