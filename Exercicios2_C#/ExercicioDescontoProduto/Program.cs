using System;

namespace Atividade_3___23._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do produto: ");
            string nomeDoProduto = Console.ReadLine();

            Console.WriteLine("Insira a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor do produto: ");
            float preco = float.Parse(Console.ReadLine());

            float totalAPagar = TotalAPagar(nomeDoProduto, quantidade, preco);

            if(totalAPagar >= 100){
                Console.WriteLine("Você receberá um brinde pela compra!");
            }else{
                Console.WriteLine("Você receberá figurinhas pela compra.");
            }


            float TotalAPagar(string nome, int quantidade, float preco){
                float total = quantidade * preco;
                float desconto;
                if(quantidade <= 5){
                    desconto = 0.02f;
                }else if(quantidade <= 10){
                    desconto = 0.03f;
                }else{
                    desconto = 0.05f;
                }
                float valorDoDesconto = total * desconto;
                float totalComDesconto = total - valorDoDesconto;

                Console.WriteLine($"Sua compra ficou em R${total}");
                Console.WriteLine($"Você irá receber R${valorDoDesconto} de desconto.");
                Console.WriteLine($"Sua compra com desconto ficou em R${totalComDesconto}");

                return totalComDesconto;
            }
            
        }
    }
}
