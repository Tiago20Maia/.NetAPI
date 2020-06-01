using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using TestDriver.Models;
using Xamarin.Forms;

namespace TestDriver.ViewModels
{
    public class ListagemViewModel : BaseViewModel
    {
        const string URL_GET_VEICULOS = "https://aluracar.herokuapp.com/";

        public ObservableCollection<Veiculo> Veiculos { get; set; }

        Veiculo veiculoSelecionado;
        public Veiculo VeiculoSelecionado
        {
            get
            {
                return veiculoSelecionado;
            }
            set
            {
                veiculoSelecionado = value;
                if (value != null)
                    MessagingCenter.Send(VeiculoSelecionado, "VeiculoSelecionado");
            }
        }

        private bool aguarde;
        public bool Aguarde
        {
            get { return aguarde; }
            set { 
                aguarde = value;
                OnPropertyChanged();
            }
        }

        public ListagemViewModel()
        {
            this.Veiculos = new ObservableCollection<Veiculo>();
        }

        public async Task GetVeiculos()
        {
            Aguarde = true;
            HttpClient cliente = new HttpClient();
            var resultado = await cliente.GetStringAsync(URL_GET_VEICULOS);

            var veiculosJson = JsonConvert.DeserializeObject<VeiculoJson[]>(resultado);

            foreach (var veiculoJson in veiculosJson)
            {
                this.Veiculos.Add(new Veiculo
                {
                    Nome = veiculoJson.nome,
                    Preco = veiculoJson.preco
                });
            }
            Aguarde = false;
        }

        class VeiculoJson
            {
            public string nome { get; set; }
            public int preco { get; set; }
        }
    }
}
