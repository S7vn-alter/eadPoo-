using eadPoo4;

class Program
{
    static void Main(string[] args)
    {
        List<Funcionario> funcionarios = new List<Funcionario>
        {
            new Gerente("Ana", "123.456.789-00", 5000),
            new Estagiario("João", "234.567.890-00", 2000),
            new FuncionarioComum("Carlos", "345.678.901-00", 3000)
        };

        Console.WriteLine("--- Lista de Pagamentos ---\n");
        foreach (var funcionario in funcionarios)
        {
            Console.WriteLine(funcionario);
        }
    }
}