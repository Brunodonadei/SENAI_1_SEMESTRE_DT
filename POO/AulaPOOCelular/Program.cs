using System;
using AulaPOOCelular.Celular;

namespace AulaPOOCelular.Celular
{
    class Program
    {
        static void Main(string[] args)
        {   
            Celular celular1 = new Celular();

            string resposta;

            do
            {
            Console.Write("Olá! deseja ligar seu celular? s/n: ");
            resposta = Console.ReadLine();


            if(resposta.ToLower() == "s"){
                celular1.ligado = true;
            }else if(resposta.ToLower() == "n"){
                celular1.ligado = false;
                celular1.TelaDoCelular(celular1.ligado);
                break;
            }
            
            celular1.TelaDoCelular(celular1.ligado);


            Console.Write("Qual a cor do seu celular? ");
            celular1.cor = Console.ReadLine();

            Console.Write("Qual o modelo do seu celular? ");
            celular1.modelo = Console.ReadLine();

            Console.Write("Quantas polegadas tem seu celular? ");
            celular1.tamanho = double.Parse(Console.ReadLine());

            Console.WriteLine($"Cor do celular: {celular1.cor}");
            Console.WriteLine($"Modelo do celular: {celular1.modelo}");
            Console.WriteLine($"Tamanho: {celular1.tamanho} polegadas.\n");




            Console.Write("Deseja enviar alguma mensagem? S/N ");
            string enviar = Console.ReadLine();
                    
            if(enviar.ToLower() == "s"){
            celular1.mensagens = true;
            celular1.Mensagem(celular1.mensagens);
            }else{
            celular1.mensagens = false;
            celular1.Mensagem(celular1.mensagens);
            }
            


            Console.Write("Deseja fazer alguma ligação? S/N ");
            string ligar = Console.ReadLine();
            if(ligar.ToLower() == "s"){
            celular1.ligacoes = true;
            celular1.FazerLigacao(celular1.ligacoes);
            }else{
            celular1.ligacoes = false;
            celular1.FazerLigacao(celular1.ligacoes);
            }

            } 
            while (resposta.ToLower() == "s");
            
            

        }
    }
}
