// imprimir  por consola  cantidad de numeros pares e impares
using System;


public class Program

{
    public static void Main(string[] args)
    {
        int[] numeros = { 30, 1, 2, 50, 4, 567, 348, 342, 560, 123, 345, 999 };
        int pares = 0;
        int impares = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
        }

        Console.WriteLine("numeros pares = " + pares);
        Console.WriteLine("nuemros impares = " + impares);
    }
}


