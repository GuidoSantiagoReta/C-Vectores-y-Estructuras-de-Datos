// ordenar sueldos  con algoritmo Bubble Sort


using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        float[] sueldos = { 4321, 4322, 6554, 3456, 8765, 6533, 34567, 56678, 5433, 5643 };
        float aux;

        for (int i = 0; i < sueldos.Length - 1; i++)
        {
            for (int j = 0; j < sueldos.Length - 1 - i; j++)
            {
                if (sueldos[j] > sueldos[j + 1])
                {
                    aux = sueldos[j];
                    sueldos[j] = sueldos[j + 1];
                    sueldos[j + 1] = aux;
                }
            }
        }
        for (int i = 0; i < sueldos.Length; i++)
        {
            Console.WriteLine("*" + sueldos[i]);
        }
        Console.WriteLine("Sueldo mayor es:" + sueldos[sueldos.Length - 1]);
        Console.WriteLine("Sueldo menor es:" + sueldos[0]);
    }
}
