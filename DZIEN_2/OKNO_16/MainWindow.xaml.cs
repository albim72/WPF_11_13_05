using System.Collections.ObjectModel;
using System.Windows;

namespace WpfDay2Exercise09;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}

public class MainViewModel
{
    public ObservableCollection<Runner> Runners { get; } = new()
    {
        new Runner("Anna", "Nowak", "Trail 33 km", "OK"),
        new Runner("Piotr", "Zieliński", "Ultra 45 km", "WARNING"),
        new Runner("Maria", "Lis", "Winter 50 km", "DNF")
    };
}

public class Runner
{
    public Runner(string firstName, string lastName, string distance, string status)
    {
        FirstName = firstName;
        LastName = lastName;
        Distance = distance;
        Status = status;
    }

    public string FirstName { get; }
    public string LastName { get; }
    public string Distance { get; }
    public string Status { get; }
    public string FullName => $"{FirstName} {LastName}";
}
