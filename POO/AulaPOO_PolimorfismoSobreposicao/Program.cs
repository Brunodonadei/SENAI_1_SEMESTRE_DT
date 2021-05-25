using System;

namespace POO_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {   
            Zero zero = new Zero();
            MegaMan mega = new MegaMan();

            mega.Correr();
            zero.Pular();
        }
    }
}
