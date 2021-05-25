using System;

namespace Exercício_nota
{
    class Program
    {
        static void Main(string[] args)

        {
            //1 - Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.

            int nota;

            do{
                Console.WriteLine("Insira uma nota entre 0 e 10.");
                nota = int.Parse(Console.ReadLine());

                if(nota <0 || nota >10){
                    Console.WriteLine("Nota inválida, digite um valor entre 0 e 10.");
                    nota = int.Parse(Console.ReadLine());
                }
                
            } while (nota <0 || nota >10);
                
            Console.WriteLine("Obrigado pela contribuição!");
            
        }
    }
}
