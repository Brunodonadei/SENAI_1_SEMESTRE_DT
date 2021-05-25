using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
          string[] listaCompras = {"maçã", "batata", "cenoura"};
            double[] precos = {1.1, 2.3, 4.5};
            int [] idades = {16, 17, 17};



            Console.WriteLine("Qual o tamanho da lista que você quer?");
            int tamanho = int.Parse(Console.ReadLine());

            string[] nomesAlunos = new string[tamanho];

            for (int i = 0; i < nomesAlunos.Length; i++)
            {
                Console.WriteLine("Digite um nome: ");
                nomesAlunos[i] = Console.ReadLine();
            }

            for (var i = 0; i < nomesAlunos.Length; i++)
            {
                Console.WriteLine(nomesAlunos[1]);
            }
        }
    }
}
