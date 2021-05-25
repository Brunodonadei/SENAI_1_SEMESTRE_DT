using System;

namespace Atividade_Passagens_áereas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool senhaValida;
            int escolha;
            int contador = 0;
            string resposta;
            
            string[] nomes = new string [5];
            string[] origem = new string [5];
            string[] destino = new string [5];
            string[] data = new string [5];


            Console.WriteLine("--------------------------------");
            Console.WriteLine("----- Sistema de passagens -----");
            Console.WriteLine("--------------------------------");

            do
            {
            Console.WriteLine("Digite a senha para acessar o sistema");
            string senha = Console.ReadLine();
            senhaValida = EfetuarLogin(senha);
            } while (!senhaValida);



            do
            {
                Console.WriteLine("Menu Principal");
                Console.WriteLine("Selecione uma opção abaixo:");
                Console.WriteLine("[1] - Cadastrar uma passagem.");
                Console.WriteLine("[2] - Listar passagens.");
                Console.WriteLine("[0] - Sair.");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Cadastro passageiro");
                        do
                        {
                            if(contador < 5)
                            {

                            Console.WriteLine($"Digite o nome {contador+1}º do passageiro.");
                            nomes[contador] = Console.ReadLine();
                            Console.WriteLine($"Digite o destino.");
                            destino[contador] = Console.ReadLine();
                            Console.WriteLine($"Digite a origem.");
                            origem[contador] = Console.ReadLine();
                            Console.WriteLine($"Qual a data do seu voo?");
                            data[contador] = Console.ReadLine();
                            contador ++;

                            }else{
                                Console.WriteLine("Limite Excedido");
                                break;
                            }
                            Console.WriteLine("Você gostaria de cadastrar um novo passageiro? s/n");
                            resposta = Console.ReadLine();

                        } while(resposta == "s");
                            Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Listar passagem");
                        for (var i = 0; i < contador; i++)
                        {
                            Console.WriteLine("--------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write($"Passageiro: ");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write($"{nomes[i]}\n");

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write($"Data do voo: ");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write($"{data[i]}\n");

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write($"Local de origem: ");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write($"{origem[i]}\n");

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write($"Local de destino: "); 
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write($"{destino[i]}\n");
                            Console.ResetColor();
                            Console.WriteLine("--------------------");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Obrigado por fazer parte da Aviações Buruno.");
                        break;
                    default:
                        break;
                }
                





            } while (escolha != 0);

            
                
           



            bool EfetuarLogin(string senha){
                if(senha == "123456"){
                    Console.WriteLine("Senha válida.");
                    return true;
                }else{
                    Console.WriteLine("Senha inválida,");
                    return false;
                }
            }
        }
    }
}
