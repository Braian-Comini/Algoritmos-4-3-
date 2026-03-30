using System;

class ConsoleApp_1
{
    static void Main()
    {
        /*
        int a = 10;
        int b = 25;
        int c = 0;

        Console.WriteLine($"Valores viejos A = {a} B = {b}.");

        c = a;
        a = b;
        b = c;

        Console.WriteLine($"Valores nuevos A = {a} B = {b}.");
        */

        int a = 10;
        int b = 25;

        Console.WriteLine($"Valores viejos A = {a} B = {b}.");

        a = a + 15;
        b = b - 15;

        Console.WriteLine($"Valores nuevos A = {a} B = {b}.");

    }
}
