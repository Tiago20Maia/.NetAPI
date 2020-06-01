namespace ByteBank
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                System.Console.WriteLine("Bemvindo ao Sistema!");
                return true;
            }

            System.Console.WriteLine("Senha incorreta!");
            return false;
        }
    }
}
