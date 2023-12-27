
/* Crear un vector de 20 elementos con valores numéricos diferentes. Hallar el mayor
 valor y su posición y el promedio.*/

/* declaración que inicializa un objeto de la clase Random llamado "rand".
   La clase Random es una clase de representa un generador de números pseudoaleatorios 
   El método Next() se puede utilizar para generar un número aleatorio entero */

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] vector = new int[20];
        double promedio = 0;
        int ValorMax = 0;
        int pos = 0;
        int aux = 0;
        double total = 0;

        Random rand = new Random();

        for (int i = 0; i < 20; i++)
        {
            vector[i] = rand.Next(0, 100);
            Console.Write("*" + vector[i]);
            aux = vector[i];

            // Sumar el valor actual al total
            total += aux;

            if (aux > ValorMax)
            {
                ValorMax = aux;
                pos = i;
            }
        }

        promedio = total / 20;

        Console.WriteLine(" El valor máximo es: " + ValorMax + " y su posición es: " + pos);
        Console.WriteLine(" El promedio es: " + promedio);
        Console.ReadLine();
    }
}