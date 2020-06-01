namespace ByteBank.Funcionarios
{
    public class GerenciadorBonificacao
    {
        private double TotalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            TotalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBinificacao()
        {
            return TotalBonificacao;
        }
    }
}
