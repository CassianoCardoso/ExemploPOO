using System;


namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected  double saldo;

        //Metodo Abstrato
        public abstract void Creditar(double valor);


        //Metodo não Abstrato
        public void ExibirSaldo()
        {
            System.Console.WriteLine($"Seu saldo é {saldo}");
        }
    }
}