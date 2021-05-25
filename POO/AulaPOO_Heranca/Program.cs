using System;
using POO_Heranca.Classes;

namespace POO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {   
            // instanciando a subclasse PessoaFisica
            PessoaFisica pf = new PessoaFisica();

            //instanciando a subclasse pessoajuridica
            PessoaJuridica pj = new PessoaJuridica();
    

            // atribuimos um cpf ao objeto
            Console.WriteLine("Olá, vamos cadastrar você no sistema.\nDigite seu cpf.");
            pf.cpf = Console.ReadLine();

            Console.WriteLine("Agora digite seu nome.");
            pf.nome = Console.ReadLine();

            //Chamando método
            Console.WriteLine(pf.DarBoasVindas(pf.nome));


            //Método de validação da subclasse
            Console.WriteLine(pf.ValidarCPF(pf.cpf));
            Console.Write($"{pf.cpf}");


        }
    }
}
