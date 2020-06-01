using System;

namespace ByteBank.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf) : base(cpf, 5000)
        {
            Console.WriteLine("Criando Gerente de Contas!");
        }

        public override void AumentarSalario()
        {
            Salario *= 0.10;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.50;
        }
    }
}
