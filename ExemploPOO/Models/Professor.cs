using System;


namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

         public override void Apresentar()
        {
            System.Console.WriteLine($"Olá , meu nome é {Nome} e o meu salario é{Salario} R$");
        }
    }
}