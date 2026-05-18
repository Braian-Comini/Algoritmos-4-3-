using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

class ConsoleApp2
{
    static void Main(String[] archivo)
    {
        int[,] escuela = {{ 15, 30, 25 },{ 12, 35, 40 }};
        bool[,] tieneInternet = new bool[2, 3];

        Console.WriteLine("Ya hay datos precargados en la escuela, desea seguir con eso o cambiarlos?");
        string? inicio = Console.ReadLine();
        if (inicio == "Si" || inicio == "si")
        {
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
                    Console.WriteLine("¿Tiene internet este lab? (S/N).");
                    string letra = Console.ReadLine();
                    bool internet;
                    while (true)
                    {
                        if (letra == "S")
                        {
                            internet = true;
                            break;
                        }
                        else if (letra == "N")
                        {
                            internet = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Solo se puede ingresar S o N.");
                            letra = Console.ReadLine();
                        }
                    }
                    escuela[i, f] = alumnos;
                    tieneInternet[i, f] = internet;
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
        }
        /*
        for (int i = 0; i < escuela.GetLength(0); i++)
        {
            Console.WriteLine("¿Tiene internet este lab? (S/N).");
            string letra = Console.ReadLine();
            bool internet;
            while (true)
            {
                if (letra == "S")
                {
                    internet = true;
                    break;
                }
                else if (letra == "N")
                {
                    internet = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Solo se puede ingresar S o N.");
                    letra = Console.ReadLine();
                }
            }
            escuela[i, f] = alumnos;
            tieneInternet[i, f] = internet;



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
        }*/

int cantidad = 0;
        int suma = escuela[0, 0] + escuela[0, 1] + escuela[0, 2];
        cantidad = cantidad + suma;
        Console.WriteLine($"En el primer piso son {cantidad} alumnos.");
        
        double promedio = 0;
        int total = 0;
        double sumaTotal = 0;
        int sinInternet = 0;
        for (int i = 0; i < 2; i++)
        {
            for (int f = 0; f < 3; f++)
            {
                if (tieneInternet[i,f] == true)
                {
                    sumaTotal += escuela[i, f];
                    total++;
                }
                else
                {

                    sinInternet++;
                }
            }
        }

        if (total > 0)
        {
            promedio = sumaTotal / total;

        }
        else
        {
            Console.WriteLine("No se encontraron elementos con internet. No se puede dividir por cero.");
        }


        Console.WriteLine($"¿Cuántos laboratorios en total tienen internet? {total}");
        Console.WriteLine($"¿Cuál es el promedio de alumnos solo en los laboratorios que SÍ tienen internet? {promedio}");
        Console.WriteLine($"ALERTA: hay {sinInternet} laboratorios sin internet");
        for (int i = 0; i < 2; i++)
        {
            for (int f = 0; f < 3; f++)
            {
                if (escuela[i, f] > 20 && tieneInternet[i, f] == false) 
                {
                    Console.WriteLine($"Se necesita asistencia en: Piso {i+1},Laboratorio {f+1} con {escuela[i,f]} alumnos.");
                }
            }
        }
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