using System;
using TestDriver.Models;
using TestDriver.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestDriver.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgendamentoView : ContentPage
    {
        public AgendamentoViewModel ViewModel { get; set; }

        public AgendamentoView(Veiculo veiculo)
        {
            InitializeComponent();
            this.ViewModel = new AgendamentoViewModel(veiculo);
            this.BindingContext = this.ViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<Agendamento>(this, "Agendamento",
                async (msg) =>
                {
                    var confirma = await DisplayAlert("Confimar Agendamento",
                        "Deseja confirmar o agendamento",
                        "Sim", "Não");
                    if (confirma)
                    {
                        this.ViewModel.SalvarAgendamento();
                    }
                });
            MessagingCenter.Subscribe<Agendamento>(this, "SucessoAgendamento",
                (msg) =>
                {
                    DisplayAlert("Agendamento", "Agendamento salvo com sucesso!", "ok");
                });

            MessagingCenter.Subscribe<ArgumentException>(this, "FalhaAgendamento",
                (msg) =>
                {
                    DisplayAlert("Agendamento", "Falha ao salvar o agendamento, tente mais tarde.", "ok");
                });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Agendamento>(this, "Agendamento");
            MessagingCenter.Unsubscribe<Agendamento>(this, "SucessoAgendamento");
            MessagingCenter.Unsubscribe<ArgumentException>(this, "FalhaAgendamento");
        }
    }
}