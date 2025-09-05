using System;

namespace Atividade3
{
    class Animal
    {
        public string Nome;
        public int Idade;
        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }

    class Program
    {
        static void Main()
        {
            Animal animal = new Animal("Leão", 5);
            Console.WriteLine("Nome: " + animal.Nome + ", Idade: " + animal.Idade);
        }
    }
}