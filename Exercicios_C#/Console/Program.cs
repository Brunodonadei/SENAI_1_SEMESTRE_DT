using System;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Digite o primeiro número:");
            Console.ForegroundColor = ConsoleColor.Green;
            string num1_texto = Console.ReadLine();
            int num1 = int.Parse(num1_texto);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Digite o segundo número:");
            Console.ForegroundColor = ConsoleColor.Green;
            int num2 = int.Parse(Console.ReadLine());
            Console.ResetColor();

            int soma = num1 + num2;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("O resultado é: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(soma);
        }
    }
}
