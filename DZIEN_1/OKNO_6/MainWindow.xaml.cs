using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Race_cutoff_judge
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private const int LimitMinutes = 290;
        private const int WarningMinutes = 15;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void JudgeButton_Click(object sender, RoutedEventArgs e)
        {
            string name = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;

            if (!int.TryParse(TimeTextBox.Text, out int timeMinutes))
            {
                ResultTextBlock.Text = "Nieprawidłowy format czasu. Wprowadź liczbę minut.";
                return;
            }

            if (timeMinutes > LimitMinutes)
            {
                ResultTextBlock.Text = $"Zawodnik {name} {lastName} został zdyskwalifikowany.";

            }
            else if (timeMinutes > LimitMinutes - WarningMinutes)
            {
                ResultTextBlock.Text = $"Zawodnik {name} {lastName} jest bliski dyskwalifikacji. Czas: {timeMinutes} minut.";
            }
            else
            {
                ResultTextBlock.Text = $"Zawodnik {name} {lastName} przeszedł kwalifikację. Czas: {timeMinutes} minut.";
            }
        }
    }
}
