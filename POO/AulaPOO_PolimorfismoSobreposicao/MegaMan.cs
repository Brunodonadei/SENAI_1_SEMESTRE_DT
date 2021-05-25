using System;
namespace POO_Polimorfismo
{
    public class MegaMan : Player
    {
        private string Buster;

        public override void Correr()
        {
            Console.WriteLine("Correndo em velocidade 100.");
        }
    }
}