using System;
namespace Desafio_3___MaquinaCafe.Classe
{
    public class MaquinaCafe
    {
        public int[] acucarDisponivel = {100};
        public int quantidadeAcucar;

        public void FazerCafe(int acucarDisponivel, int quantidadeAcucar){
            if(acucarDisponivel < quantidadeAcucar){
                Console.WriteLine("Não há açucar o suficiente para fazer o café.");
            }else{
                Console.WriteLine($"Fazendo café com {quantidadeAcucar} gramas de açucar.");
            }
        }

        public void FazerCafe(){
            if(acucarDisponivel[100] < 10){
                Console.WriteLine("Fazendo café sem açucar.");
            }
        }
    }
}