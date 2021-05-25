using System;

namespace Projeto_semáforo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a cor do semáforo (Vermelho, Amarelo ou Verde)");
            string cor = (Console.ReadLine());

            
            if(cor == "Vermelho"){
                Console.WriteLine("Pare o carro!");
            }
            
            else if(cor == "Amarelo"){
                Console.WriteLine("Desacelere o carro!");
            }
            else{
                Console.WriteLine("Prossiga");
            }
        }
    }
}
