using System;
using System.Threading;

namespace tabuada_exercicio_fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int fator = 1; fator <= 10; fator++)
            {
                for (int fator2 = 1; fator2 <=10; fator2++)
                {
                    Console.WriteLine($"{fator} * {fator2} = {fator * fator2}");
                    Thread.Sleep(200);
                }
            }
            
        }
    }
}