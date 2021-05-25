using System;
namespace ExemploAula.aluno
{
    public class aluno
    {
        public string nome;

        public string curso;

        public int idade;

        public string rg;

        public bool bolsista;

        public double mediaFinal;

        public double valorDaMensalidade;

        public void VerMediaFinal(double media){
            Console.WriteLine($"A média do aluno é: {media}");
        }

        public void VerMensalidade(bool temBolsa, double mensalidade){
            if(temBolsa == true){
                Console.WriteLine("Esse aluno é bolsista.");
                Console.WriteLine($"Mensalidade: {mensalidade}");
                Console.WriteLine($"Mensalidade com desconto: {mensalidade - (mensalidade * 0.3)}");
            }else{
                Console.WriteLine("Esse aluno NÃO é bolsista");
                Console.WriteLine($"Mensalidade: {mensalidade}");
            }
        }
    }
}
