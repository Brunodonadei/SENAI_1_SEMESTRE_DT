using System;
using Desafio_3___MaquinaCafe.Classe;

namespace Desafio_3___MaquinaCafe
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaCafe maquina = new MaquinaCafe();
            string resposta;
                
                for (var i = 0; i <= 100 ; maquina.quantidadeAcucar--)
                {
            do
            {
                    
            Console.WriteLine($"Essa é a sua máquina de café, quantidade disponível de açucar em gramas: {maquina.acucarDisponivel[i] - maquina.quantidadeAcucar}g\nQuantos gramas deseja utilizar?");
            maquina.quantidadeAcucar = int.Parse(Console.ReadLine());
            

            if(maquina.acucarDisponivel[i] > 10){
                maquina.FazerCafe(maquina.acucarDisponivel[i], maquina.quantidadeAcucar);
            }else{
                maquina.FazerCafe();
            }


            Console.WriteLine("Deseja fazer outro café? [s/n]");
            resposta = Console.ReadLine();

            } while (resposta == "s");
                }
        }
    }
}
