using ReactiveUI;
using System.Collections.ObjectModel;

namespace ObservableCollectionTest.ViewModels;

public class MainViewModel : ViewModelBase
{
    private string _item;
    public string Item
    {
        get => _item;
        set => this.RaiseAndSetIfChanged(ref _item, value);
    }
    public ObservableCollection<string> MyItems { get; set; } = new ObservableCollection<string>();
    public void AddItem()
    {
        MyItems.Add(Item);
        Item = "";
    }
}
