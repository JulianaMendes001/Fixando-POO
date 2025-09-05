class Aluno 
{
 public string Nome;
    public double Nota;
}

class Program
{
    static void Main()
    {
        Aluno a1 = new Aluno();
        a1.Nome = "Ana";
        a1.Nota = 8.5;

        Aluno a2 = new Aluno();
        a2.Nome = "Bruno";
        a2.Nota = 7.0;

        if (a1.Nota > a2.Nota)
            Console.WriteLine(a1.Nome + " tem a maior nota.");
        else
            Console.WriteLine(a2.Nome + " tem a maior nota.");
    }
}
