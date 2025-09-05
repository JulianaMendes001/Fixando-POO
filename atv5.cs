using System;

namespace Atividade5
{
    class Quadrado
    {
        public double Lado;
        public Quadrado(double lado)
        {
            Lado = lado;
        }
        public double Area()
        {
            return Lado * Lado;
        }
    }

    class Program
    {
        static void Main()
        {
            Quadrado quadrado = new Quadrado(4);
            Console.WriteLine("Área do quadrado: " + quadrado.Area());
        }
    }
}
