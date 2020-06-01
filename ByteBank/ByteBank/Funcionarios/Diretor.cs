using System;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {
            Console.WriteLine("Criando Diretor"); 
        }

        public override void AumentarSalario()
        {
            Salario *= 0.05;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
