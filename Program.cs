using System;

namespace Exerc_cioIMC
{
    class Program
    {
        static void Main(string[] args)
        {   
            double alt,peso,imc;
            Console.Beep();
            Console.Clear();
            Console.Write("Digite sua altura em (metros):");
            alt= double.Parse(Console.ReadLine());
            Console.Write("Digite seu peso (kg)");
            peso= double.Parse(Console.ReadLine());

            imc= peso/Math.Pow(alt,2);
            Console.WriteLine($"Altura: {alt:N2} kg /nPeso: {peso} m");
            Console.Write($"/nIMC:");
            Console.ForegroundColor= ConsoleColor.DarkCyan;
            Console.WriteLine($"{imc:N2} kg/m^2");
            Console.ResetColor();
        }
    }
}
