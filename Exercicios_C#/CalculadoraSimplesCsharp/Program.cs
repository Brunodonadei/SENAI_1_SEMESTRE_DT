using System;

namespace Calculadora_Simples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a operação que deseja realizar: \n----------------------- \nAdição \n----------------------- \nSubtração \n----------------------- \nMultiplicação \n----------------------- \nDivisão \n-----------------------");
            Console.ForegroundColor = ConsoleColor.Blue;
            String operacao = Console.ReadLine();
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Digite o pirmeiro número: ");

            Console.ForegroundColor = ConsoleColor.Green;
            float num1 = float.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Digite o segundo número: ");

            Console.ForegroundColor = ConsoleColor.Green;
            float num2 = float.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;

            float resultado = 0;

            switch (operacao){
                case "Adição":
                    resultado = num1 + num2;
                break;

                case "Subtração":
                    resultado = num1 - num2;
                break;

                case "Multiplicação":
                    resultado = num1 * num2;
                break;

                case "Divisão":
                    resultado = num1 / num2;
                break;

                default:
                    operacao = "Inválida";
                    Console.WriteLine("operação Inválida");
                break;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"O resultado da sua operação é: ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{resultado}");
            
            
        
        }
    }
}