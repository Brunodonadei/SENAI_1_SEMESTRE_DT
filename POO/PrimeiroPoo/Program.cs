using System;

namespace PrimeiroPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instaciando objeto

          predefinicoes jogador1 = new predefinicoes();
          jogador1.nome = "Bruno de ferro";
          jogador1.idade = 17;
          jogador1.armadura = "FaceShield";
          jogador1.iA = "Pure Skill";

          predefinicoes jogador2 = new predefinicoes();
          jogador2.nome = "Dummy";
          jogador2.idade = 999;
          jogador2.armadura = "MK3";
          
          Console.Clear();
          Console.WriteLine($"Partida = {jogador1.nome} VS {jogador2.nome}");
          Console.WriteLine($"Idade Jogador 1: {jogador1.idade} || Idade Jogador 2: {jogador2.idade}");
          Console.WriteLine($"Armadura Jogador 1: {jogador1.armadura} || Armadura Jogador 2: {jogador2.armadura}");
          Console.WriteLine($"Jogador 1 IA: {jogador1.iA} || Jogador 2 IA: {jogador2.iA}");

          int vidaDoJogador2 = jogador2.Defesa(jogador2.Ataque1());
          if(vidaDoJogador2 <= 0){
                    Console.WriteLine("O jogador morreu");
          }else{
               Console.WriteLine($"Jogador 2 depois do ataque ficou com {jogador2.vida} de vida");
        }
    }
}
}
