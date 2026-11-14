using AppHotelMelissa.ViewModels;

namespace AppHotelMelissa.Views;

public partial class MainPage : ContentPage
{
    private readonly ReservaViewModel _viewModel = new();

    public MainPage()
    {
        InitializeComponent();
        BindingContext = _viewModel;
    }

    private async void OnReservarClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Solicitação de reserva", $"Sua seleção:\n{_viewModel.Resumo}\n\nEste é um protótipo acadêmico. Nenhuma reserva real foi efetuada.", "Entendi");
    }

    private async void OnSobreClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SobrePage());
    }

    private async void OnExperienciasClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ExperienciasPage());
    }
}
