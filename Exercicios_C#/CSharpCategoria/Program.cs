using System;

namespace Exercicio_extra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, insira a sua idade para determinarmos a sua categoria.");
            int idade = int.Parse(Console.ReadLine());

            if(idade >= 5 && idade <= 7){
                Console.WriteLine("Você pertence à categoria Infantil A.");
                }
                if(idade >= 8 && idade <=10){
                    Console.WriteLine("Você pertence à categoria Infantil B.");
                }
                if(idade >=11 && idade <=13){
                    Console.WriteLine("Você pertence à categoria Juvenil A.");
                }
                if(idade >= 14 && idade <= 17){
                    Console.WriteLine("Você pertence a categoria Juvenil B.");
                }
                if(idade >= 18){
                    Console.WriteLine("Você pertence à categoria Sênior.");
                }

        
            }
        }
    }

