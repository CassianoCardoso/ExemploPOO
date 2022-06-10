using System;


namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
         public  override void Apresentar() // O uso da palavra "sealed" não permite derivar de utras classes filhas 
        {
            System.Console.WriteLine($"Diretor");
        }
    }
}