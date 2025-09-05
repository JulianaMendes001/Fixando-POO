using System;

namespace Atividade2
{
    class Carro
    {
        public string Cor = "Vermelho";
    }

    class Program
    {
        static void Main()
        {
            Carro carro = new Carro();
            Console.WriteLine("Cor do carro: " + carro.Cor);
        }
    }
}