using System;

class Programa
{
    static void Main(string[] args)
    {
        Random dice = new Random();
        int roll1 = dice.Next(1, 61);
        int roll2 = dice.Next(1, 61);
        int roll3 = dice.Next(1, 61);
        int roll4 = dice.Next(1, 61);
        int roll5 = dice.Next(1, 61);
        int roll6 = dice.Next(1, 61);

        Console.WriteLine($"Resultados: {roll1},{roll2},{roll3},{roll4},{roll5},{roll6}");
    }
}
