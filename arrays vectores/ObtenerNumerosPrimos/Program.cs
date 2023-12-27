//contar la cantidad de números primos en una matriz de números enteros

using System;

public class Program

{
    public static void Main(string[] args)
    {
        int[] numeros = { 3, 7, 8, 6, 9 };
        int contPrimos = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            int contDivisores = 0;

            for (int j = 2; j <= numeros[i] / 2; j++)
            {
                if (numeros[i] % j == 0)
                {
                    contDivisores++;
                   
                }
            }

            if (contDivisores == 0 && numeros[i] != 1)
            {
                contPrimos++;
            }
        }

        Console.WriteLine("Cantidad de numeros primos: " + contPrimos);
    }
}

