using System;

class actividad_1
{
    static void Main()
    {
        int[] laboratorios = new int[5];
        
            for (int i = 0; i < laboratorios.Length; i++)
            {
            
                Console.WriteLine($"Ingrese la cantidad de alumnos para el laboratorio {i+1}: ");
                string? input = Console.ReadLine();
                while (!int.TryParse(input , out laboratorios[i]))
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingresá un número entero.");
                    input = Console.ReadLine();
                }
            
            
            }
        
        int total_alumnos = new int() + laboratorios[5];
        Console.WriteLine($"El total de alumnos es: {total_alumnos}");
        

        






    }
}