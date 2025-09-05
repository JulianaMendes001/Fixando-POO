 class Calculadora
    {
        public double Somar(double x, double y) { return x + y; }
        public double Subtrair(double x, double y) { return x - y; }
        public double Multiplicar(double x, double y) { return x * y; }
        public double Dividir(double x, double y) { return y == 0 ? double.NaN : x / y; }
    }