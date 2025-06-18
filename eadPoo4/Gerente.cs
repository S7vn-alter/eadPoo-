using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eadPoo4
{
  public class Gerente : Funcionario
{
    private const double Bonus = 2000.0;

    public Gerente(string nome, string cpf, double salarioBase)
        : base(nome, cpf, salarioBase)
    {
    }

    public override double CalcularSalarioFinal()
    {
        return SalarioBase + Bonus;
    }

    public override string ExibirDados()
    {
        return $"Nome: {Nome} Gerente | Salário Final: R$ {CalcularSalarioFinal():F2}";
    }
}
}