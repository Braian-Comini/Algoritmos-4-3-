using System;

class ConsoleApp2 
{
    static void Main()
    {
        int[,] escuela = new int[2, 3];
        
        for (int i = 0;i < escuela[2,3];i++)
        {
            Console.WriteLine($"Ingrese la cantidad de alumnos para el piso {i + 1} laboratorio {i + 1}: ");
            string? input = Console.ReadLine();
            while (!int.TryParse(input, out i))
            {
                Console.WriteLine("Entrada no válida. Por favor, ingresá un número entero.");
                input = Console.ReadLine();
            }
            for (int f = 0;f < escuela[2,3];f++)
            {
                Console.WriteLine($"Ingrese la cantidad de alumnos para el piso {f + 1} laboratorio {f + 1}: ");
                string? input = Console.ReadLine();
                while (!int.TryParse(input, out f))
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingresá un número entero.");
                    input = Console.ReadLine();
                }
            }
        }
        Console.WriteLine($"total;"+ escuela);
    }
}