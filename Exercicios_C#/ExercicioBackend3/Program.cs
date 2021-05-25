using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu salário no ano de 2020?");
            int salario = int.Parse(Console.ReadLine());

            if(salario <500){
                double ajuste = salario*1.30;
                Console.WriteLine("Parabéns! Você receberá um aumento de 30%, seu salário total será de: "+ajuste);
            }else{
                Console.WriteLine("Você não tem direito ao aumento.");
            }
        }
    }
}