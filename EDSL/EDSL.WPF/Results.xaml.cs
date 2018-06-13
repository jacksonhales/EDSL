using EDSL.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Results.xaml
    /// </summary>
    public partial class Results : Page
    {

        public ObservableCollection<Game> gamesList { get; set; }

        public Results()
        {
            InitializeComponent();

            List<string> seasonList = new List<string>();
            seasonList.Add("2018");

            cmbSeason.ItemsSource = seasonList;
            cmbSeason.SelectedItem = seasonList.First();

            List<string> divisionList = new List<string>();
            divisionList.Add("2018A");
            divisionList.Add("2018B");
            divisionList.Add("2018C");

            cmbDivision.ItemsSource = divisionList;
            cmbDivision.SelectedItem = divisionList.First();

            List<string> roundList = new List<string>();
            roundList.Add("1");
            roundList.Add("2");
            roundList.Add("3");
            roundList.Add("4");
            roundList.Add("5");
            roundList.Add("6");
            roundList.Add("7");
            roundList.Add("8");
            roundList.Add("9");
            roundList.Add("10");
            roundList.Add("11");
            roundList.Add("12");
            roundList.Add("13");
            roundList.Add("14");
            roundList.Add("15");
            roundList.Add("16");
            roundList.Add("17");
            roundList.Add("18");
            roundList.Add("19");
            roundList.Add("20");

            cmbRound.ItemsSource = roundList;
            cmbRound.SelectedItem = roundList.First();

            gamesList = new ObservableCollection<Game>()
            {
                new Game()
                {
                    GameNumber = "1",
                    HomeTeam = "WANTIRNA-A",
                    HomeGoals = "0",
                    AwayTeam = "SCORESBY-A",
                    AwayGoals = "1"
                },
                new Game()
                {
                    GameNumber = "2",
                    HomeTeam = "MOUNT WAVERLEY-A",
                    HomeGoals = "2",
                    AwayTeam = "MITCHAM-A",
                    AwayGoals = "2"
                },
                new Game()
                {
                    GameNumber = "3",
                    HomeTeam = "RINGWOOD-A",
                    HomeGoals = "4",
                    AwayTeam = "MOUNT EVELYN-A",
                    AwayGoals = "0"
                },
                new Game()
                {
                    GameNumber = "4",
                    HomeTeam = "WONGA PARK-A",
                    HomeGoals = "0",
                    AwayTeam = "LILYDALE-A",
                    AwayGoals = "1"
                },
                new Game()
                {
                    GameNumber = "5",
                    HomeTeam = "BELGRAVE-A",
                    HomeGoals = "2",
                    AwayTeam = "MURRUMBEENA-A",
                    AwayGoals = "1"
                },
                new Game()
                {
                    GameNumber = "6",
                    HomeTeam = "BEACONSFIELD UPPER-A",
                    HomeGoals = "0",
                    AwayTeam = "FERNTREE GULLY-A",
                    AwayGoals = "0"
                }
            };
            this.DataContext = this;


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
