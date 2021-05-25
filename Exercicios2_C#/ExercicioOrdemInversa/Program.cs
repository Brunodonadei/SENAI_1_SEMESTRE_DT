using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};
            int[] inversao = new int [vetor.Length];

            for (int i = 0; i < vetor.Length; i++)
            {
                inversao[i] = vetor [(vetor.Length - i) - 1];
                Console.WriteLine(inversao[i] + "");
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
