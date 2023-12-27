//Ordenar una matriz  utilizando el algoritmo Bubble Sort.

using System;

public class OrdenamientoBurbuja
{
    public static void Main(string[] args)
    {
        int aux = 0;
        int[] numeros = { 5, 7, 10, 1 };
        for (int i = 0; i < numeros.Length - 1; i++)
        {
            for (int j = 0; j < numeros.Length - 1 - i; j++)
            {
                if (numeros[j] > numeros[j + 1])
                {
                    aux = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = aux;
                }
            }
        }
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}
