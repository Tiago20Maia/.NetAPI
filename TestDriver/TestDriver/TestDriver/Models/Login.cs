namespace TestDriver.Models
{
    public class Login
    {
        public Login(string email, string senha)
        {
            this.email = email;
            this.senha = senha;
        }

        public string email { get; set; }
        public string senha { get; set; }
    }
}
