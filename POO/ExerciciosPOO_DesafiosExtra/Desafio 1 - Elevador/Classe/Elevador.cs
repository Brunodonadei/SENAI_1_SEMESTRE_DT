using System;
namespace Desafio_1___Elevador.Classe
{
    public class Elevador
    {
        private int andarAtual = 0;
        public int AndarAtual{
            get{return andarAtual;}
            set{andarAtual = value;}
        }
        private int totalAndares = 10;
        public int TotalAndares{
            get{return totalAndares;}
        }
        private int capacidadeElevador = 10;
        public int CapacidadeElevador{
            get{return capacidadeElevador;}
        }
        private int pessoas = 0;
        public int Pessoas{
            get{return pessoas;}
            set{pessoas = value;}
        }

        public void Inicializa(int capacidadeElevador, int totalAndares){
            Console.WriteLine($"Esse é o nosso elevador eletrônico, bem vindo(a)!\nO elevador possui um total de {totalAndares} andares e uma capacidade de até {capacidadeElevador}.");
        }

        public string Entrar(){
            return "Você entrou no elevador.";
        }

        public string Sair(){
            return "Você saiu do elevador.";
        }

        public void Subir(){
            Console.WriteLine($"subindo um andar, indo para o andar: {andarAtual + 1}");
        }

        public void Descer(){
            Console.WriteLine($"Descendo um andar, indo para o andar: {andarAtual - 1}");
        }
    }
}