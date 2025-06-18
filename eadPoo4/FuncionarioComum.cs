using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eadPoo4
{
  public class FuncionarioComum : Funcionario
{
    public FuncionarioComum(string nome, string cpf, double salarioBase)
        : base(nome, cpf, salarioBase)
    {
    }

    public override string ExibirDados()
    {
        return $"Nome: {Nome} Comum | Salário Final: R$ {CalcularSalarioFinal():F2}";
    }
}
}
