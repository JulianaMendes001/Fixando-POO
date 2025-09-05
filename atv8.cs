class ContaBancaria
{
    public double Saldo = 0;

    public void Depositar(double valor)
    {
        Saldo += valor;
    }
}

class Program
{
    static void Main()
    {
        ContaBancaria conta = new ContaBancaria();
        conta.Depositar(100);
        Console.WriteLine("Saldo: " + conta.Saldo);
    }
}