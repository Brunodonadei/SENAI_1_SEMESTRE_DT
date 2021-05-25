using System;
using Desafio_1___Elevador.Classe;

namespace Desafio_1___Elevador
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevador elevador = new Elevador();

            elevador.Inicializa(elevador.CapacidadeElevador, elevador.TotalAndares);

            Console.WriteLine("Você deseja entrar no elevador? [s/n]");
            string resposta = Console.ReadLine();

            if(resposta == "s"){
                Console.WriteLine(elevador.Entrar());
            }else{
                Console.WriteLine("Okay, volte outro dia.");
            }

            Console.WriteLine("Você deseja sair do elevador? [s/n]");
            string resposta2 = Console.ReadLine();

            if(resposta2 == "s"){
                Console.WriteLine(elevador.Entrar());
            }else{
                Console.WriteLine("Voce continua no elevador");
            }

            Console.WriteLine("Você deseja subir um andar?");
            string resposta3 = Console.ReadLine();

            if(resposta3 == "s"){
                elevador.Subir();
            }else{
                Console.WriteLine($"Parado no {elevador.AndarAtual} andar");
            }

            Console.WriteLine("Você deseja descer um andar?");
            string resposta4 = Console.ReadLine();

            if(resposta4 == "s"){
                elevador.Descer();
            }else{
            Console.WriteLine($"Parado no {elevador.AndarAtual} andar.");
            }
        }
    }
}
