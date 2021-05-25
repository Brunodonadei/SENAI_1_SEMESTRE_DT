using System;

namespace Exercício_nome_de_usuário_e_senha
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string senha;

            do{
                Console.WriteLine("Se quiser prosseguir, por favor digite seu nome de usuário.");
                nome = Console.ReadLine();

                Console.WriteLine("Agora, digite sua senha.");
                senha = Console.ReadLine();

                if (nome == senha){
                    Console.WriteLine("Insira um nome de usuário diferente da senha.");
                }
                
            } while (nome == senha);
                Console.WriteLine("Sua conta foi gerada.");
        }
    }
}
