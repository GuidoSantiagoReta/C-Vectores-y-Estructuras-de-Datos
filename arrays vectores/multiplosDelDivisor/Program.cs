/* Dados 5 números y un divisor:
determinar cuántos números múltiplos hay del divisor en los 5 números ingresados.
usando el operador módulo (%), que devuelve el residuo de la división de dos números.
Si el residuo es cero, significa que un número es múltiplo del otro. */ 

using System;

public class Program

{
    public static void Main(string[] args)
    {
        int[] numeros = { 3, 7, 8, 6, 9 };
        int divisor = 2;
        int contmultiplos = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] % divisor == 0)
            {
                contmultiplos++;
            }
        }

        Console.WriteLine("Hay " + contmultiplos + " numeros multiplos de " + divisor + " en las posiciones del array.");
    }
} 