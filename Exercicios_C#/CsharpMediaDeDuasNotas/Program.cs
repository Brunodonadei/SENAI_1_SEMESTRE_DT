using System;

namespace Projeto_Média_de_nota
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            Console.WriteLine("A média desse aluno foi de: " + media);

            if (media < 6) {
                Console.WriteLine("O aluno foi reprovado!");
            }
            else {
                Console.WriteLine("O aluno passou de ano!");
            }

        }
    }
}
