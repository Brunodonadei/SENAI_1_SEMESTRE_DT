using System;
using ExemploAula.aluno;

namespace ExemploAula.aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            aluno aluno1 = new aluno();

            Console.Write("Digite o nome do aluno: ");
            aluno1.nome = Console.ReadLine();

            Console.Write("Insira o nome do curso: ");
            aluno1.curso = Console.ReadLine();

            Console.Write("Insira a idade do aluno: ");
            aluno1.idade = int.Parse(Console.ReadLine());

            Console.Write("Insira o RG do aluno: ");
            aluno1.rg = Console.ReadLine();

            Console.Write("O aluno é bolsista? (S/N): ");
            string resposta = Console.ReadLine();

            if(resposta.ToLower() == "s"){
                aluno1.bolsista = true;
            }else if(resposta.ToLower() == "n"){
                aluno1.bolsista = false;
            }

            Console.Write("Insira a média do aluno: ");
            aluno1.mediaFinal = double.Parse(Console.ReadLine());

            Console.Write("Insira o valor da mensalidade: ");
            aluno1.valorDaMensalidade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Nome do aluno: {aluno1.nome}");
            Console.WriteLine($"Cursando: {aluno1.curso}");
            Console.WriteLine($"Idade: {aluno1.idade}");
            Console.WriteLine($"RG: {aluno1.rg}");
            Console.WriteLine($"O aluno é bolsista: {resposta}");
            Console.WriteLine($"Valor da mensalidade: {aluno1.valorDaMensalidade}");

            aluno1.VerMediaFinal(aluno1.mediaFinal);
            aluno1.VerMensalidade(aluno1.bolsista, aluno1.valorDaMensalidade);
        }
    }
}
