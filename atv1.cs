using System;

namespace ExerciciosPOO
{
    class Pessoa
    {
        public string Nome;
        public int Idade;
    }
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa pessoa = new Pessoa();

            pessoa.Nome = "Juliana";
            pessoa.Idade = 20;

            Console.WriteLine("Nome: " + pessoa.Nome);
            Console.WriteLine("Idade: " + pessoa.Idade);
        }
    }
}