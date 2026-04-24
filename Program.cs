using System;
class ConsoleApp2
{
    static void Main()
    {
        int[,] escuela = new int[2, 3];
        int piso = 0;
        int laboratorio = 0;

        for (int i = 0; i < escuela.GetLength(0); i++)
        {
            Console.WriteLine($"Ingrese alumnos del piso {i + 1}: ");
            string? floor = Console.ReadLine();
            while (!int.TryParse(floor, out piso))
            {
                Console.WriteLine("Entrada no válida. Por favor, ingresá un número entero.");
                floor = Console.ReadLine();
                piso = i;
                
            }
            for (int f = 0; f < escuela.GetLength(1); f++)
            {
                Console.WriteLine($"Ingrese alumnos del laboratorio {f + 1}: ");
                string? lab = Console.ReadLine();
                while (!int.TryParse(lab, out laboratorio))
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingresá un número entero.");
                    lab = Console.ReadLine();
                    laboratorio = f;
                   
                }
            }
        }
        Console.WriteLine($"Pisos: {piso}");
        Console.WriteLine($"Labs: {laboratorio}");
        Console.WriteLine($"Total escuela: {escuela}");

        //Ingresar piso y lab para consultar datos.
        //Usar tryparce para error EJ: si consulta piso 5 (no existe).
        /*bool datos_validos = false;
        int consulta = 0;
        int consulta2 = 0;

        Console.WriteLine("Ingrese piso a consultar: ");
        string? input = Console.ReadLine();
        if(int.TryParse(input, out consulta))
        {
            if(input == )
            {

            }
        }
        else
        {
            Console.WriteLine("Dato inválido, ingrese el piso correspondiente.");
            input = Console.ReadLine();
        }*/
        

    }
}
























/*for (int a = 0; a < 2; a++)
        {
            Console.WriteLine("Ingrese el piso a consultar: ");
            string? input = Console.ReadLine();
            while (!int.TryParse(input, out piso))
            {
                Console.WriteLine("Dato inválido, ingrese el piso correspondiente.");
                input = Console.ReadLine();
                piso = escuela.GetLength(0);
                Console.WriteLine(escuela);
                continue;
                
            }
            for (int b = 0; b < 3; b++)
            {
                Console.WriteLine("Ingrese el laboratorio a consultar: ");
                string? input2 = Console.ReadLine();
                while (!int.TryParse(input2, out laboratorio))
                {
                    Console.WriteLine("Dato inválido, ingrese el laboratorio correspondiente.");
                    input = Console.ReadLine();
                    laboratorio = escuela.GetLength(1);
                    Console.WriteLine(escuela);
                    datos_validos = true;
                    break;
                 
                }
            }


        }

        Console.WriteLine($"Varialble datos_validos: {datos_validos} ");
        Console.WriteLine($"Piso: {piso} ");
        Console.WriteLine($"Laboratorio: {laboratorio} ");
        */