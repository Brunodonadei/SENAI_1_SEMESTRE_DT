using System;
using Desafio_2___Jogador.Classe;

namespace Desafio_2___Jogador
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador jog = new Jogador();
            string resposta;
            
        do
        {
            
            Console.WriteLine("Bem vindo(a) ao registro de jogadores(as)!");
            Console.Write("Insira seu nome: ");
            jog.nome = Console.ReadLine();

            Console.Write("Insira seu ano de nascimento: ");
            jog.AnoNascimento = int.Parse(Console.ReadLine());

            Console.Write("Insira sua nacionalidade: ");
            jog.nacionalidade = Console.ReadLine();

            Console.Write("Insira sua altura (exemplo: 1,75): ");
            jog.altura = Console.ReadLine();

            Console.Write("Insira seu peso (exemplo: 70kg): ");
            jog.peso = Console.ReadLine();

            Console.WriteLine("Insira sua posição por escrito dentre as opções:\n[1] - Atacante\n[2] - Defesa\n[3] - Meio-campo");
            jog.posicao = Console.ReadLine();
            Console.Clear();




            Console.WriteLine(jog.MostrarDados());

            jog.Aposentar(jog.posicao, jog.CalcularIdade());

            Console.WriteLine("Deseja fazer o cadastro de novo? [s/n]");
            resposta = Console.ReadLine();


        } while (resposta == "s");
        }
    }
}
