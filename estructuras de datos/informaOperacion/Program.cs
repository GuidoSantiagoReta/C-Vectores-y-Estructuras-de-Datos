// Ejercicio de operaciones multiplicacion y division

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer numero");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero");
        int num2 = int.Parse(Console.ReadLine());

        int suma = num1 + num2;
        int diferencia = num1 - num2;

        Console.WriteLine("La suma de los números es:" + suma);
        Console.WriteLine("La diferencia entre los números es:" + diferencia);

        if (num1 <= num2)
        {
            int producto = num1 * num2;
            double division = (double)num1 / num2;

            Console.WriteLine("El producto de los números es:" + producto);
            Console.WriteLine($"La división del primer número respecto al segundo es:{division}");
        }
    }
}
