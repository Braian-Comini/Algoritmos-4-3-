using System;
class Programa
{
    static void Main()
    {
        int alumnos;
        int computadoras;

        Console.WriteLine("Indica la cantidad de alumnos: ");
        while (!int.TryParse(Console.ReadLine(), out alumnos))
        {
            Console.WriteLine("Entrada no válida. Por favor, ingresá un número entero.");
        }

        Console.WriteLine("Indica la cantidad de computadoras: ");
        while (!int.TryParse(Console.ReadLine(), out computadoras))
        {
            Console.WriteLine("Entrada no válida. Por favor, ingresá un número entero.");
        }

        double promedio = (double)alumnos / computadoras;

        if (alumnos > computadoras)
        {
            Console.WriteLine("Faltan equipos");
        }
        else if (computadoras >= alumnos)
        {
            Console.WriteLine("Equipos suficientes");
        }




    }
}
/*
class Pasaje
{
    static void Main()
    {
        int A = 3;
        int B = 4;
        int C = A + B;
        Console.WriteLine("Resultado de A + B: ");
        Console.WriteLine(C);
    }
    
}
*/