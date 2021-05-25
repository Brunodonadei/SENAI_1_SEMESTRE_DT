using System;
using POO_Polimorfismo_Sobrecarga.Classes;

namespace POO_Polimorfismo_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun = new Funcionario();
            fun.Mostrar();
            fun.Mostrar("Bruno");
            fun.Mostrar(2);
           
            
        }
    }
}
