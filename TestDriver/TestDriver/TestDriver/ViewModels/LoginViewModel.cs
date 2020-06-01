using System.Windows.Input;
using TestDriver.Models;
using Xamarin.Forms;

namespace TestDriver.ViewModels
{
    public class LoginViewModel
    {
        private string usuario;
        public string Usuario
        {
            get { return usuario; }
            set
            {
                usuario = value;
                ((Command)EntrarCommand).ChangeCanExecute();
            }
        }

        private string senha;
        public string Senha
        {
            get { return senha; }
            set
            {
                senha = value;
                ((Command)EntrarCommand).ChangeCanExecute();
            }
        }

        public ICommand EntrarCommand { get; set; }

        public LoginViewModel()
        {
            EntrarCommand = new Command(async () =>
            {
                var loginService = new LoginService();
                await loginService.FazerLogin(new Login(usuario, senha));
            }, () =>
                {
                    return !string.IsNullOrEmpty(usuario)
                    && !string.IsNullOrEmpty(senha);
                });
        }
    }
}

