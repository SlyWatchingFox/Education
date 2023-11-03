using ReactiveUI;
using System.Collections.ObjectModel;

namespace ObservableCollectionTest.ViewModels;

public class MainViewModel : ViewModelBase
{
    private string _name;
    private int _age;
    public string Name
    {
        get => _name;
        set => this.RaiseAndSetIfChanged(ref _name, value);
    }
    public int Age
    {
        get => _age;
        set => this.RaiseAndSetIfChanged(ref _age, value);
    }
    public ObservableCollection<Person> Persons { get; set; } = new ObservableCollection<Person>();
    public void AddPerson()
    {
        Persons.Add(new Person(Name,Age));
        Name = "";
        Age = 0;
    }
}
