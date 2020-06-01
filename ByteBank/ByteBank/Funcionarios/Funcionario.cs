namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public Funcionario(string cpf, double salario)
        {
            System.Console.WriteLine("Criando Funcionario");

            Cpf = cpf;
            Salario = salario;
            TotalDeFuncionario++;
        }

        public static int TotalDeFuncionario { get; set; }

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; protected set; }

        public abstract void AumentarSalario();
        
        public abstract double GetBonificacao();
        
    }
}
