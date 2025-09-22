using System;

class Program
{
    static void Main()
    {
        int numero = int.Parse(Console.ReadLine()!);

        if (numero % 2 == 0)
            Console.WriteLine("PAR");
        else
            Console.WriteLine("ÍMPAR");
    }
}
