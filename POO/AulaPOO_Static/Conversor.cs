using System;
namespace POO_Static
{
    public static class Conversor
    {
        private static float cotacaoDolar = 5.10f;
        private static float cotacaoEuro = 6.21f;

        public static float valorUsuario;

        public static void ExibirDados(){
            Console.WriteLine($"Sua conversão de Dólar para Real: R${ConverterDolarParaReal()}.");
            Console.WriteLine($"Sua conversão de Real para Dólar: ${ConverterRealEmDolar()}.");
            Console.WriteLine($"Sua conversão de Euro para Real: R${ConverterEuroParaReal()}.");
            Console.WriteLine($"Sua conversão de Real para Euro: £{ConverterRealEmEuro()}.");
        }

        public static float ConverterDolarParaReal(){
            return valorUsuario * cotacaoDolar;
        }

        public static float ConverterRealEmDolar(){
            return valorUsuario / cotacaoDolar;
        }

        public static float ConverterEuroParaReal(){
            return valorUsuario * cotacaoEuro;
        }

        public static float ConverterRealEmEuro(){
            return valorUsuario / cotacaoEuro;
        }
    }
}