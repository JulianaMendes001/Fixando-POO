  {
        public List<string> contatos;
        public Agenda(List<string> c) { contatos = c; }
        public string Buscar(string nome)
        {
            foreach (var c in contatos)
                if (c.ToLower() == nome.ToLower())
                    return c;
            return null;
        }
    }