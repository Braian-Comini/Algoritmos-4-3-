using System;

class ConsoleApp1
{
    static void Main()
    {
        int[] laboratorios = new int[5];

        for (int i = 0; i < laboratorios.Length; i++)
        {

            Console.WriteLine($"Ingrese la cantidad de alumnos para el laboratorio {i + 1}: ");
            string? input = Console.ReadLine();
            while (!int.TryParse(input, out laboratorios[i]))
            {
                Console.WriteLine("Entrada no válida. Por favor, ingresá un número entero.");
                input = Console.ReadLine();
            }


        }

        int total_alumnos = laboratorios.Sum();
        Console.WriteLine($"El total de alumnos es: {total_alumnos}");

        int max_alumnos = laboratorios.Max();
        Console.WriteLine($"El laboratorio con mayor cantidad de alumnos es: {max_alumnos}");
        
        int count = 1;
        foreach (int laboratorio in laboratorios)
        {
            Console.WriteLine($"Alumnos en Laboratorio {count}: " + laboratorio);
            count++;
        }







    }
}