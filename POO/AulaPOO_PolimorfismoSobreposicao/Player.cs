using System;
namespace POO_Polimorfismo
{
    public class Player
    {
        private float velocidade;
        private float forcaPulo;

        public virtual void Correr(){
            Console.WriteLine("Correndo em velocidade 10.");
        } 

        public virtual void Pular(){
            Console.WriteLine("Pulo alcançando 20m.");
        }
    }
}