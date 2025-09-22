using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o raio do círculo: ");
        double raio = double.Parse(Console.ReadLine()!);

        double area = Math.PI * Math.Pow(raio, 2);

        Console.WriteLine("A área do círculo é: " + area);
    }
}
