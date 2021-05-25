using System;
namespace POO_Polimorfismo
{
    public class Zero : Player
    {
        private string Sword;

        public override void Pular()
        {
            Console.WriteLine("Pulo aumentado para um limite de 60m.");
        }
    }
}