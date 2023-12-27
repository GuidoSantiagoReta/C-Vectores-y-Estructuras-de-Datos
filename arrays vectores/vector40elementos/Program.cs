/* En un vector de 40 elementos numéricos llamado totales, se requiere ir sumando y
mostrando cada elemento, siempre y cuando sea mayor al primer elemento y menor
al elemento 25. Finalmente, muestre la suma */

/* declaración que inicializa un objeto de la clase Random llamado "rand".
   La clase Random es una clase de representa un generador de números pseudoaleatorios 
   El método Next() se puede utilizar para generar un número aleatorio entero */
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] totales = new int[40];
        int suma = 0;

        Random rand = new Random();
        for (int i = 0; i < 40; i++)
        {
            totales[i] = rand.Next(0, 70);
        }
        for (int i = 0; i < 40; i++)
        {
            if (totales[i] > totales[0] && totales[i] < totales[39])
            {
                suma += totales[i];
            }
        }
        Console.WriteLine("La suma es: " + suma);
    }
}