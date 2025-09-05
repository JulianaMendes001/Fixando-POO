 class Funcionario
    {
        public string Nome;
        public double Salario;
        public Funcionario(string nome, double salario) { Nome = nome; Salario = salario; }
        public void AumentarSalario(double pct) { Salario += Salario * pct / 100; }
    }