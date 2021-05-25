using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseja saber a tabuada de qual número?");
            int resposta = int.Parse(Console.ReadLine());

            int resultado;


            for (int contador = 0; contador <= 100; contador ++)
            {
                resultado = resposta * contador;
                Console.WriteLine($"{resposta} * {contador} = {resultado}");

                
            }
        }
    }
}
