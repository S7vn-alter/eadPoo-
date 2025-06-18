using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eadPoo4
{
   public class Estagiario : Funcionario
{
    public Estagiario(string nome, string cpf, double salarioBase)
        : base(nome, cpf, salarioBase)
    {
    }

    public override double CalcularSalarioFinal()
    {
        return SalarioBase * 0.8;
    }

    public override string ExibirDados()
    {
        return $"Nome: {Nome} Estagiário | Salário Final: R$ {CalcularSalarioFinal():F2}";
    }
}
}