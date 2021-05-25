using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu ano de nascimento.");
            int nascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora, digite o ano atual");
            int ano = int.Parse(Console.ReadLine());

            int idade = (ano - nascimento);
            int semanas = (idade*52);

            Console.WriteLine("Você tem " + idade + " anos ou " + semanas + " semanas de idade.");
        }
    }
}