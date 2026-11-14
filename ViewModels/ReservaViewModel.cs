using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppHotelMelissa.ViewModels;

public class ReservaViewModel : INotifyPropertyChanged
{
    private int _hospedes = 2;
    private DateTime _checkIn = DateTime.Today.AddDays(1);
    private string? _tipoQuarto = "Suíte Jardim";

    public event PropertyChangedEventHandler? PropertyChanged;
    public IReadOnlyList<string> TiposQuarto { get; } = new[]
    {
        "Suíte Jardim", "Suíte Vista Mar", "Quarto Família", "Suíte Premium"
    };

    public int Hospedes
    {
        get => _hospedes;
        set { if (_hospedes == value) return; _hospedes = value; OnPropertyChanged(); OnPropertyChanged(nameof(Resumo)); }
    }

    public DateTime CheckIn
    {
        get => _checkIn;
        set { if (_checkIn == value) return; _checkIn = value; OnPropertyChanged(); OnPropertyChanged(nameof(Resumo)); }
    }

    public string? TipoQuarto
    {
        get => _tipoQuarto;
        set { if (_tipoQuarto == value) return; _tipoQuarto = value; OnPropertyChanged(); OnPropertyChanged(nameof(Resumo)); }
    }

    public string Resumo => $"{Hospedes} hóspede(s) • {TipoQuarto ?? "Escolha uma suíte"} • {CheckIn:dd/MM/yyyy}";

    private void OnPropertyChanged([CallerMemberName] string? name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
