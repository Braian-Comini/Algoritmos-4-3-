using System;

class ConsoleApp2 
{
    static void Main()
    {
        int[,] escuela = new int[2, 3];
        int piso = escuela[0,0];
        int laboratorio = escuela[0,0];
        
        for (int i = 0; i < escuela.GetLength(0); i++)
        {
            Console.WriteLine($"Ingrese alumnos del piso {i + 1}: ");
            string? floor = Console.ReadLine();
            while (!int.TryParse(floor, out piso))
            {
                Console.WriteLine("Entrada no válida. Por favor, ingresá un número entero.");
                floor = Console.ReadLine();
            }
            for (int f = 0;f < escuela.GetLength(1);f++)
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

        for(int j = 0; j < escuela.GetLength(0); j++)
        {
            Console.WriteLine($"Ingrese el piso a consultar: ");
            string? input = Console.ReadLine();
            while(!int.TryParse(input, out piso))
            {
                Console.WriteLine("Entrada no válida. Por favor, ingresá un número entero.");
                input = Console.ReadLine();
            }
            for(int k = 0;k < escuela.GetLength(1); k++)
            {
                Console.WriteLine("Ingrese el laboratorio a consultar: ");
                string? input2 = Console.ReadLine();
                while (!int.TryParse(input2, out laboratorio))
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingresá un número entero.");
                    input2 = Console.ReadLine();
                }
                string a = input;
                string b = input2;
                if(a == "1")
                {
                 
                    if(b == "1")
                    {

                    }
                    
                }else if(a == "2")
                {

                }

            }


        }



        
    }
}