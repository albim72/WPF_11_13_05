using System.Collections.ObjectModel;
using System.Windows;

namespace WpfDay2Exercise04;

public partial class MainWindow : Window
{
    private readonly MainViewModel _viewModel = new();

    public MainWindow()
    {
        InitializeComponent();
        DataContext = _viewModel;
    }

    private void AddButton_Click(object sender, RoutedEventArgs e)
    {
        string firstName = FirstNameTextBox.Text.Trim();
        string lastName = LastNameTextBox.Text.Trim();

        if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
        {
            MessageBox.Show("Podaj imię i nazwisko.");
            return;
        }

        _viewModel.Runners.Add(new Runner(firstName, lastName));
        FirstNameTextBox.Clear();
        LastNameTextBox.Clear();
    }
}

public class MainViewModel
{
    public ObservableCollection<Runner> Runners { get; } = new()
    {
        new Runner("Anna", "Nowak"),
        new Runner("Piotr", "Zieliński")
    };
}

public class Runner
{
    public Runner(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; }
    public string LastName { get; }
    public string DisplayName => $"{FirstName} {LastName}";
}
