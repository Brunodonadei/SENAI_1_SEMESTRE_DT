using System;

namespace Aula_20._11
{
    class Program
    {
        static void Main(string[] args)
        { 



            string[] nomes = new string[10];
            float[] nota1 = new float[10];
            float[] nota2 = new float[10];
            float[] nota3 = new float[10];
            float[] nota4 = new float[10];
            float[] media = new float[10];
            float[] mediaTotal = new float[1];

            string[] dados = new string[10];

            for (var i = 0; i < dados.Length; i++)
            {
                Console.WriteLine("Digite o nome do aluno " + i);
                nomes [i] = Console.ReadLine();

                Console.WriteLine("Digite a nota do primeiro bimestre");
                nota1 [i] = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite a nota do segundo bimestre");
                nota2 [i] = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite a nota do terceiro bimestre");
                nota3 [i] = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite a nota do quarto bimestre");
                nota4 [i] = float.Parse(Console.ReadLine());

                media[i]= (nota1[i]+nota2[i]+nota3[i]+nota4[i])/4;
            }

            for (var i = 0; i <=10; i++){

                Console.WriteLine("");

            if(media[i]>7){
                Console.WriteLine("A média do(a) estudante: " + nomes[i] + " foi: " + media[i]);
                Console.WriteLine("ALUNO(A) APROVADO(A)");
            }else{
                Console.WriteLine("A média do(a) estudante: " + nomes[i] + " foi: " + media[i]);
                Console.WriteLine("ALUNO(A) REPROVADO(A)");
            }     

            // for (var i = 0; i = 1; i++)
            // {
            // mediaTotal[i] = (media[i] + media[i] + media[i]) / 3;
            // Console.WriteLine("A média total da classe é: " + mediaTotal[i]);  
            // }  
            

        }
    }
}
}
