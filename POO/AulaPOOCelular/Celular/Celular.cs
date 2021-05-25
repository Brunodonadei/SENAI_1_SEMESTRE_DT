using System;
namespace AulaPOOCelular.Celular
{
    public class Celular
    {
        public string cor;

        public string modelo;

        public double tamanho;

        public bool ligado;

        public bool mensagens;
        
        public bool ligacoes;

        public void TelaDoCelular(bool tela){
            if(tela == true){
                Console.WriteLine("O celular está ligado.");
            }else{
                Console.WriteLine("O celular está desligado.");
            }
        }

        public void Mensagem(bool mensagem){
             if(mensagem == true){
                Console.WriteLine("Escreva a mensagem: ");
                string mensagens = Console.ReadLine();

                Console.WriteLine("Sua mensagem foi enviada!");
             }else{
                 Console.WriteLine("Ops, ocorreu um erro e sua mensagem não será enviada.");
             }
        }

        public void FazerLigacao(bool ligacao){
            if(ligacao == true){
            Console.WriteLine("Para quem?");
            string quem = Console.ReadLine();
            Console.WriteLine("Ligando...");
            Console.WriteLine($"A(O) {quem} não atendeu! Deixe uma mensagem.");

            }else{
                Console.WriteLine("Não foi possível completar a ligação.");
            }
    }
}
}