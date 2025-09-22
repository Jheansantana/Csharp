using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra ou frase: ");
        string texto = Console.ReadLine()!;

        Console.Write("Digite a letra que deseja contar: ");
        char letra = char.Parse(Console.ReadLine()!);

        int contador = 0;

        for (int i = 0; i < texto.Length; i++)
        {
            if (texto[i] == letra)
            {
                contador++;
            }
        }

        Console.WriteLine($"A letra '{letra}' aparece {contador} vez(es).");
    }
}
