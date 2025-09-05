class Usuario
    {
        public string nome, email;
        public Usuario(string n, string e) { nome = n; email = e; }
        public void TrocarEmail(string novo) { email = novo; }
    }
