using System;

namespace Exercício_formulário
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            float salario;
            string civil;

            do
            {
                Console.WriteLine("Insira seu nome");
                nome = Console.ReadLine();

                if (nome == "")
                {
                    Console.WriteLine("É necessário inserir mais que 0 caracteres para prosseguir.");

                }

            } while (nome == "");
            Console.WriteLine("Próxima etapa:");

            do
            {
                Console.WriteLine("Insira a sua idade");
                idade = int.Parse(Console.ReadLine());

                if (idade < 0 || idade > 150)
                {
                    Console.WriteLine("Idade são somente válidas de 0 até 150 anos.");
                }


            } while (idade < 0 || idade > 150);
            Console.WriteLine("Próxima etapa:");

            do
            {
                Console.WriteLine("Insira seu salário, apenas os números, nenhum carácter especial.");
                salario = float.Parse(Console.ReadLine());

                if (salario <= 0)
                {
                    Console.WriteLine("Seu salário precisa ser maior que 0.");
                }


            } while (salario <= 0);
            Console.WriteLine("Próxima etapa:");

            do
            {
                Console.WriteLine("Informe seu estado civíl [c/s/v/d] onde:\n c = casado\n s = solteiro\n v = viúvo\n d = divorciado ");
                civil = Console.ReadLine();

                if (civil == "c" && civil == "s" && civil == "v" && civil == "d")
                {
                    Console.WriteLine("Insira um estado civíl válido dentre as opcções [c/s/v/d] onde:\n c = casado\n s = solteiro\n v = viúvo\n d = divorciado");
                    break;
                }



            } while (civil != "c" && civil != "s" && civil != "v" && civil != "d");
            Console.WriteLine("Obrigado por contribuir!");


            Console.WriteLine("-------------------------------");
            Console.WriteLine("Confirme seus dados");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Salario: " + salario);
            Console.WriteLine("Estado Civil: " + civil);
            Console.WriteLine("-------------------------------");

        }
    }
}
