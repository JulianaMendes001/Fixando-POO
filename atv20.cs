using System;
{
    class Jogo
    {
        public string nome;
        public string console;
        public bool jogando;

        public Jogo(string n, string c)
        {
            nome = n;
            console = c;
            jogando = false;
        }

        public void Jogar()
        {
            jogando = true;
            Console.WriteLine(nome + " começou no " + console + "!");
        }

        public void Parar()
        {
            if (jogando)
            {
                jogando = false;
                Console.WriteLine(nome + " parado.");
            }
            else
            {
                Console.WriteLine(nome + " não está jogando.");
            }
        }

        public void VerStatus()
        {
            Console.WriteLine("Jogo: " + nome + ", Console: " + console + ", Jogando: " + jogando);
        }
    }

    class Program
    {
        static void Main()
        {
            Jogo meuJogo = new Jogo("Zelda", "Switch");
            meuJogo.VerStatus();
            meuJogo.Jogar();
            meuJogo.VerStatus();
            meuJogo.Parar();
            meuJogo.VerStatus();
        }
    }
}