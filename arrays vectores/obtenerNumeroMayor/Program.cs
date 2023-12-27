// Dados 5 números, obtener el número mayor.
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] numeros = { 3 ,7, 8, 6, 9 };
        int max = 0;
        for(int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] > max)       //compara el elemento si el actual es mayor que max actualiza max con el valor del elemento actual
            {
                max = numeros[i];
            }
        }
          Console.WriteLine("El numero mas grande es:" +max);
    }
}