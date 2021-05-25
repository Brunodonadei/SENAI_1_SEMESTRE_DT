using System;

namespace atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vamos descobrir se você já pode votar!\nInsira o ano atual: " );
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Ótimo! Agora insira o seu ano de nascimento: " );
            int anoNas = int.Parse(Console.ReadLine());
            int idade = ano - anoNas;

            if(idade >= 16 && idade <= 17){
                Console.WriteLine("Você tem " +idade+ " anos, pode votar, mas não é obrigatório.");
            }
            else if (idade < 16){
                Console.WriteLine("Você tem " +idade+ " anos, ainda não pode votar.");
            }
            else
            {
                Console.WriteLine("Você tem " +idade+ " anos, agora é obrigatório o voto, caso contrário terá de pagar uma multa.");
            }
        }
    }
}
