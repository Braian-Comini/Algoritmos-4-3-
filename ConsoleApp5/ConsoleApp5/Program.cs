using System;
class consoleApp5
{
    static void Main()
    {
        int[,,] nave1 = new int[2, 3, 4];
        int[,,] nave2 = new int[2, 3, 4];
        int tripulantes = 20;
        int izq = 0;
        int der = 0;
        int mando = 0;
        int motor = 0;
        int armamento = 0;
        int sector = 0;

        Console.WriteLine("La guerra galáctica ha comenzado. Dos comandantes se enfrentan en un sector del espacio.\n El objetivo es eliminar a la tripulación enemiga antes de que ellos eliminen la tuya.");
        //Console.ForegroundColor = ConsoleColor.Green;
        for (int a = 0; a < 2; a++)
        {
            Console.WriteLine($"Jugador {a+1}");
            Console.WriteLine($"En que zona de la nave quiere distribuir tripulantes?\n Ala: [Izq] [Der]\nCápsula de: [Mando] [Motor] [Armamento]\nHabitaciones: Sector [0,1,2,3] ");
            string zona = Console.ReadLine();
            Console.WriteLine("Cuantos quiere distribuir?");
            while (true)
            {
                if(zona == "Izq" || zona == "izq")
                {

                }
            }
        }
    }
}