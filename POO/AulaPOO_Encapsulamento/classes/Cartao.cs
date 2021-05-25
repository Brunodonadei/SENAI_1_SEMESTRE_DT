namespace POO_Encapsulamento.classes
{
    public class Cartao
    {
        private string numero;
        public string Numero{
            get{return numero;}
            set{numero = value;}
        }
        private string nomeTitular;
        public string NomeTitular{
            get{return nomeTitular;}
            set{nomeTitular = value;}
        }
        private string bandeira;
        public string Bandeira{
            get{return bandeira;}
            set{bandeira = value;}
        }
        protected string token = "qwertyui";
        public string Token{
            get{return token;}
        }
        private string cvv;
        public string CVV{
            get{return cvv;}
            set{cvv = value;}
        }
        protected float limite = 5000;
        public float Limite{
            get{return limite;}
            set{limite = value;}
        }

        //Métodos

        public string RegistrarCompra(bool validado){
            return "";
        }

        public string ReceberNome(string nomeDigitado){
            return this.nomeTitular = nomeDigitado; 
        }

        public void ExibirNome(){
            System.Console.WriteLine(this.nomeTitular);
        }

        
    }
}