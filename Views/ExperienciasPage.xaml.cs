namespace AppHotelMelissa.Views;

public partial class ExperienciasPage : ContentPage
{
    public ExperienciasPage() => InitializeComponent();

    private async void OnVoltarClicked(object sender, EventArgs e) => await Navigation.PopAsync();
}
