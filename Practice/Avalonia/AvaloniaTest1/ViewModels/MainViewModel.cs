using Avalonia.Interactivity;
using ReactiveUI;
using System;
using System.Globalization;

namespace AvaloniaTest1.ViewModels;

public class MainViewModel : ViewModelBase
{
    private int _number;
    public int Number
    {
        get => _number;
        set => this.RaiseAndSetIfChanged(ref _number, value);
    }
    public string ButtonIncreaseNumber => "+1";
    public string ButtonDecreaseNumber => "-1";
    public void IncreaseNumber()
    {
        Number += 1;
    }
    public void DecreaseNumber()
    {
        Number -= 1;
    }
}
