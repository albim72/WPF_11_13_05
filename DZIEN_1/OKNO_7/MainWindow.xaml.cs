using System.Windows;
using System.Windows.Controls;

namespace WpfDay1Exercise10;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void RunnersListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (RunnersListBox.SelectedItem is ListBoxItem selectedItem)
        {
            SelectedRunnerTextBlock.Text = $"Wybrano: {selectedItem.Content}";
        }
    }
}
