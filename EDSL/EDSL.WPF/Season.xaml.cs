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

namespace EDSL.WPF
{
    /// <summary>
    /// Interaction logic for Season.xaml
    /// </summary>
    public partial class Season : Page
    {
        public Season()
        {
            InitializeComponent();

            dpkStartDate.Text = DateTime.Today.ToString();

            List<string> divisions = new List<string>();

            divisions.Add("2018A");
            divisions.Add("2018B");
            divisions.Add("2018C");

            cmbDivision.ItemsSource = divisions;
            cmbDivision.SelectedItem = divisions.First();
        }

        private void btnSeason_Click(object sender, RoutedEventArgs e)
        {
            Season seasonPage = new Season();
            NavigationService.Navigate(seasonPage);
        }

        private void btnResults_Click(object sender, RoutedEventArgs e)
        {
            Results resultsPage = new Results();
            NavigationService.Navigate(resultsPage);
        }
    }
}
