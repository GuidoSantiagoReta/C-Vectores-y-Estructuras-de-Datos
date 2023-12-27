
using System;
// ordenamiento burbuja: ordenar matriz  de  mayor a menor
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] numeros = { 30, 1, 2, 50, 4, 567, 348, 342, 560, 123, 345, 99 };
        int aux = 0;

        for (int i = 0; i < 11; i++)
        {
            for (int j = 0; j < 11 - i; j++)
            {
                if (numeros[j] < numeros[j + 1])
                {
                    aux = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = aux;
                }
            }
        }
        for (int i = 0; i < 12; i++)
        {
            Console.Write("*" + numeros[i]);
        }
    }
}
