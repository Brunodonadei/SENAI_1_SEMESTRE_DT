using System;

namespace POO_Static
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um valor para converter.");
            Conversor.valorUsuario = float.Parse(Console.ReadLine());
            Conversor.ExibirDados();
        }
    }
}
