using System;
namespace Desafio_2___Jogador.Classe
{
    public class Jogador
    {
        //Crie uma classe para representar um jogador de futebol, com os atributos nome, posição, data de nascimento, nacionalidade, altura e peso. Crie um método para imprimir todos os dados do jogador. Crie um método para calcular a idade do jogador e outro método para mostrar quanto tempo falta para o jogador se aposentar. Para isso, considere que os jogadores da posição de defesa se aposentam em média aos 40 anos, os jogadores de meio-campo aos 38 e os atacantes aos 35.

        
        public string nome;
        public string posicao;
        private int anoNascimento;
        public int AnoNascimento{
            get{return anoNascimento;}
            set{anoNascimento = value;}
        }      
        public string nacionalidade;
        public string altura;
        public string peso;

        public string MostrarDados() => ($"Nome: {nome}\nPosição: {posicao}\nAno de nascimento: {anoNascimento}\nNacionalidade: {nacionalidade}\nAltura: {altura}\nPeso: {peso}\nIdade: {this.CalcularIdade()}");

        public int CalcularIdade(){
            DateTime data = DateTime.Now;
            int ano = data.Year;
            int idade = ano - anoNascimento;
            return idade;
        }

        public void Aposentar(string posicao, int anos){
            if(posicao == "Defesa" && this.CalcularIdade() <= 40){
                Console.WriteLine($"Faltam {40 - anos} anos para você se aposentar.");
            }else if(posicao == "Meio-campo" && this.CalcularIdade() <= 38){
                Console.WriteLine($"Faltam {38 - anos} anos para você se aposentar.");
            }else if(posicao == "Atacante" && this.CalcularIdade() <= 35){
                Console.WriteLine($"Faltam {35 - anos} anos para você se aposentar.");
            }else{
                Console.WriteLine("Você já deveria estar aposentado ou não inseriu uma posição válida!");

        }
    }
    }
}