using System;

namespace Atividade4
{
    class Livro
    {
        public string Titulo;
        public string Autor;
        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }
        public void ExibirInfo()
        {
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Autor: " + Autor);
        }
    }

    class Program
    {
        static void Main()
        {
            Livro livro = new Livro("O Pequeno Príncipe", "Antoine de Saint-Exupéry");
            livro.ExibirInfo();
        }
    }
}