using System.Windows;
using System.Windows.Controls;

namespace WpfDay2Exercise11.Controls;

public partial class RunnerCard : UserControl
{
    public RunnerCard()
    {
        InitializeComponent();
    }

    public string RunnerName
    {
        get => (string)GetValue(RunnerNameProperty);
        set => SetValue(RunnerNameProperty, value);
    }

    public static readonly DependencyProperty RunnerNameProperty =
        DependencyProperty.Register(nameof(RunnerName), typeof(string), typeof(RunnerCard), new PropertyMetadata(""));

    public string Distance
    {
        get => (string)GetValue(DistanceProperty);
        set => SetValue(DistanceProperty, value);
    }

    public static readonly DependencyProperty DistanceProperty =
        DependencyProperty.Register(nameof(Distance), typeof(string), typeof(RunnerCard), new PropertyMetadata(""));

    public string Status
    {
        get => (string)GetValue(StatusProperty);
        set => SetValue(StatusProperty, value);
    }

    public static readonly DependencyProperty StatusProperty =
        DependencyProperty.Register(nameof(Status), typeof(string), typeof(RunnerCard), new PropertyMetadata(""));
}
