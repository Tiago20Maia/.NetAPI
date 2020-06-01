using System.Windows.Input;
using TestDriver.Models;
using Xamarin.Forms;

namespace TestDriver.ViewModels
{
    public class DetalheViewModel : BaseViewModel
    {
        public Veiculo Veiculo { get; set; }

        public string TextoFreioABS
        {
            get
            {
                return string.Format("Freios ABS - R$ {0}", Veiculo.FREIO_ABS);
            }
        }

        public string TextoArCondicionado
        {
            get
            {
                return string.Format("Ar condicionado - R$ {0}", Veiculo.AR_CONDICIONADO);
            }
        }

        public string TextoMP3
        {
            get
            {
                return string.Format("MP3 - R$ {0}", Veiculo.MP3_PLAYER);
            }
        }

        public string ValorTotal
        {
            get
            {
                return Veiculo.ValorTotalFormatado;
            }
        }

        public bool TemFreioABS
        {
            get
            {
                return Veiculo.TemFreioABS;
            }
            set
            {
                Veiculo.TemFreioABS = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public bool TemArcondicionado
        {
            get
            {
                return Veiculo.TemArcondicionado;
            }
            set
            {
                Veiculo.TemArcondicionado = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public bool TemMP3
        {
            get
            {
                return Veiculo.TemMP3;
            }
            set
            {
                Veiculo.TemMP3 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }
        public DetalheViewModel(Veiculo veiculo)
        {
            this.Veiculo = veiculo;
            ProximoCommand = new Command(() =>
            {
                MessagingCenter.Send(veiculo, "Proximo");
            });
        }

        public ICommand ProximoCommand { get; set; }
    }
}
