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
        else if (alumnos >= computadoras)
        {
            Console.WriteLine("Equipos suficientes");
        }

        Console.WriteLine($"El promedio de alumnos por computadoras es: {promedio:N2}");



    }
}
