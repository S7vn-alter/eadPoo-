using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eadPoo4
{
   public class Funcionario
{
    public string Nome;
    public string CPF;
    public double SalarioBase;

    public Funcionario(string nome, string cpf, double salarioBase)
    {
        Nome = nome;
        CPF = cpf;
        SalarioBase = salarioBase;
    }

    public virtual double CalcularSalarioFinal()
    {
        return SalarioBase;
    }

    public virtual string ExibirDados()
    {
        return $"Nome: {Nome} | Salário Final: R$ {CalcularSalarioFinal():F2}";
    }

    public override string ToString()
    {
        return ExibirDados();
    }
}
}
