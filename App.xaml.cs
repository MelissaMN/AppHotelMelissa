namespace AppHotelMelissa;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new NavigationPage(new Views.MainPage())
        {
            BarBackgroundColor = Color.FromArgb("#26a4a0"),
            BarTextColor = Colors.White
        };
    }
}
