class Biblioteca
    {
        public List<string> livros;
        public Biblioteca() { livros = new List<string>(); }
        public void Adicionar(string titulo) { livros.Add(titulo); }
    }