using System;

namespace POO_Polimorfismo_Sobrecarga.Classes
{
    public class Funcionario
    {
        public string[] lista = {"Bruno", "Gustavo", "Marcio", "Elaine"};

        public void Mostrar()
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        public void Mostrar(int indice)
        {
            Console.WriteLine("Busca por índice: " + lista[indice]);
        }

        public void Mostrar(string busca)
        {
            foreach (var item in lista)
            {
                if(item == busca){
                    Console.WriteLine($"Resultado da busca: {item}");
                }
            }
        }

    }
}