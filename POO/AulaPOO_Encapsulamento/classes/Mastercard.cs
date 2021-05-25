namespace POO_Encapsulamento.classes
{
    public class Mastercard : Cartao
    {
        private int parcelas;

        public void ExibirLimite(){
            System.Console.WriteLine(this.limite);
        }
    }
}