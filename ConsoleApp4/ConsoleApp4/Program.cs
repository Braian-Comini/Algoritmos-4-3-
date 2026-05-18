using System;
using System.IO;
using System.Xml.Serialization;

class ConsoleApp2
{
    static void Main(String[] archivo)
    {
        int[,] escuela = new int[2, 3];
        bool[,] tieneInternet = new bool[2, 3];

        for (int i = 0; i < escuela.GetLength(0); i++)
        {
            for (int f = 0; f < escuela.GetLength(1); f++)
            {
                Console.WriteLine($"Ingrese alumnos del piso {i + 1} laboratorio {f + 1}: ");
                string? labs = Console.ReadLine();
                int alumnos;
                while (!int.TryParse(labs, out alumnos))
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingresá un número entero.");
                    labs = Console.ReadLine();
                }

                 letra = Console.WriteLine("¿Tiene internet este lab? (S/N).");
                if()
                escuela[i, f] = alumnos;
            }
        }

        while (true)
        {
            Console.WriteLine("Ingrese piso a consultar (1-2):");
            string? p = Console.ReadLine();
            Console.WriteLine("Ingrese el laboratorio a consultar (1-3):");
            string? l = Console.ReadLine();

            int piso, lab;


            if (int.TryParse(p, out piso) && int.TryParse(l, out lab))
            {

                if (piso >= 1 && piso <= 2 && lab >= 1 && lab <= 3)
                {
                    Console.WriteLine($"En el Piso {piso}, Lab {lab} hay: {escuela[piso - 1, lab - 1]} alumnos");
                    break;
                }
                else
                {
                    Console.WriteLine("Piso o Laboratorio fuera de rango.");
                }
            }
            else
            {
                Console.WriteLine("Ingresar números enteros válidos.");
            }
        }
        int cantidad = 0;
        int suma = escuela[0, 0] + escuela[0, 1] + escuela[0, 2];
        cantidad = cantidad + suma;
        Console.WriteLine($"En el primer piso son {cantidad} alumnos.");

        string txt = "";
        for (int a = 0; a < escuela.GetLength(0); a++)
        {
            for (int b = 0; b < escuela.GetLength(1); b++)
            {
                txt += $"Piso {a + 1}, Lab {b + 1}: {escuela[a, b]} alumnos\n";
            }
        }
        File.WriteAllText("reporte_escuela.txt", txt);
        Console.WriteLine("Datos guardados con éxito en el disco");

    }
}