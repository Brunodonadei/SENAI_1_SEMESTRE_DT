using System;
using POO_Encapsulamento.classes;

namespace POO_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Mastercard m = new Mastercard();

            m.NomeTitular = "Bruno Donadei Manfredini";

            m.Numero = "12345678";

            m.Bandeira = "Mastercard";

            m.CVV = "556";

            Console.WriteLine($"O títular: {m.NomeTitular}\nToken: {m.Token}\nNúmero: {m.Numero}\nBandeira: {m.Bandeira}\nCVV: {m.CVV}\nLimite: {m.Limite}");
        }
    }
}
