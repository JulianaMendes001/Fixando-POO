class Ponto
{
    public double X;
    public double Y;

    public double DistanciaOrigem()
    {
        return Math.Sqrt(X * X + Y * Y);
    }
}

class Program
{
    static void Main()
    {
        Ponto p = new Ponto();
        p.X = 3;
        p.Y = 4;

        Console.WriteLine("Distância da origem: " + p.DistanciaOrigem());
    }
}
