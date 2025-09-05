class Program
{
    static void Main()
    {
        Produto p = new Produto();
        p.Nome = "Notebook";
        p.Preco = 3000;

        p.AplicarDesconto();
        Console.WriteLine("Preço com desconto: " + p.Preco);
    }
}
