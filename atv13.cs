    class Data
    {
        public int Dia, Mes, Ano;
        public Data(int d, int m, int a) { Dia = d; Mes = m; Ano = a; }
        public string Mostrar() { return Dia.ToString("D2") + "/" + Mes.ToString("D2") + "/" + Ano; }
    }