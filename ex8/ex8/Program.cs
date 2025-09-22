using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int n = int.Parse(Console.ReadLine()!);

        bool ehPrimo = true;

        if (n <= 1)
        {
            ehPrimo = false;
        }
        else
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    ehPrimo = false;
                    break;
                }
            }
        }

        if (ehPrimo)
            Console.WriteLine($"{n} é PRIMO");
        else
            Console.WriteLine($"{n} NÃO é primo");
    }
}
