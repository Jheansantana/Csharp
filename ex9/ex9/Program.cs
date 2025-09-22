using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra: ");
        string texto = Console.ReadLine()!;

        string invertida = "";

        for (int i = texto.Length - 1; i >= 0; i--)
        {
            invertida += texto[i];
        }

        Console.WriteLine("Invertida: " + invertida);
    }
}
