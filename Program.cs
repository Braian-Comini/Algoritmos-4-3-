using System;
class ConsoleApp2
{
    static void Main()
    {
        int[,] escuela = new int[2, 3];
        int piso = 0
        int laboratorio = 0

        for (int i = 0; i < escuela.GetLength(0); i++)
        {
            Console.WriteLine($"Ingrese alumnos del piso {i + 1}: ");
            string? floor = Console.ReadLine();
            while (!int.TryParse(floor, out piso))
            {
                Console.WriteLine("Entrada no válida. Por favor, ingresá un número entero.");
                floor = Console.ReadLine();
            }
            for (int f = 0; f < escuela.GetLength(1); f++)
            {
                Console.WriteLine($"Ingrese alumnos del laboratorio {f + 1}: ");
                string? lab = Console.ReadLine();
                while (!int.TryParse(lab, out laboratorio))
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingresá un número entero.");
                    lab = Console.ReadLine();
                }
            }
        }

        //Ingresar piso y lab para consultar datos.
        //Usar tryparce para error EJ: si consulta piso 5 (no existe).
        bool datos_validos = false;

        for (int a = 0;a < escuela.GetLength(0); a++)
        {
            Console.WriteLine("Ingrese el piso a consultar: ");
            string? input = Console.ReadLine();
            while (!int.TryParse(input, out piso))
            {
                if(piso >= 0 && piso < a) 
                {
                    Console.WriteLine(escuela);
                    continue;
                }
            }
            for(int b = 0; b < escuela.GetLength(1); b++)
            {
                Console.WriteLine("Ingrese el laboratorio a consultar: ");
                string? input2 = Console.ReadLine();
                while(!int.TryParse(input2, out laboratorio))
                {
                    Console.WriteLine(escuela);
                    datos_validos = true;
                }
            }

            }
        }
        




    }
}