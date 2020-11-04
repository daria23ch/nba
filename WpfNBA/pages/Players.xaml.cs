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

namespace WpfNBA.pages
{
    /// <summary>
    /// Логика взаимодействия для Players.xaml
    /// </summary>
    public partial class Players : Page
    {
        NBAShortEntities context;
        string currentLetter="";
        public Players()
        {
            InitializeComponent();
            lettersABC();
            context = new NBAShortEntities();
            cmbSeason.ItemsSource = context.Seasons.ToList();
            cmbTeam.ItemsSource = context.Teams.ToList();
            dataGridPlayers.ItemsSource = context.PlayerInTeams.ToList();
        }
       

        private void showTable()
        {
            if (cmbSeason.SelectedItem == null || cmbTeam.SelectedItem==null)
            {
                return;
            }
            var currentSeason = (Season)cmbSeason.SelectedItem;
            var currentTeam = cmbTeam.SelectedItem as Team;
            string searchText = txtPlayerName.Text;
            List<PlayerInTeam> listPlayerInTeam = context.PlayerInTeams.ToList();
            listPlayerInTeam = listPlayerInTeam.Where(x => x.Season == currentSeason && x.TeamId == currentTeam.TeamId).ToList();
            dataGridPlayers.ItemsSource = listPlayerInTeam;
            listPlayerInTeam = listPlayerInTeam.Where(x => x.Player.Name.ToLower().Contains(searchText.ToLower())).ToList();
            if (currentLetter.Count() == 1)
            {
                listPlayerInTeam = listPlayerInTeam.Where(x => x.Player.Name.Contains(currentLetter)).ToList();
                
            }
            dataGridPlayers.ItemsSource = listPlayerInTeam.OrderBy(x => x.ShirtNumber).ToList();
        }

      

        private void lettersABC()
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                TextBlock letters = new TextBlock
                {
                    Text = i.ToString(),
                    FontWeight = FontWeights.Bold,
                    Foreground = Brushes.White,
                    Margin = new Thickness(5)
                };
                //    letters.Mo
                letters.MouseLeftButtonDown += TextBlock_MouseLeftButtonDown;
                stackLetters.Children.Add(letters);
            }
        }
        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var label = (TextBlock)sender;
            currentLetter = label.Text;
            foreach (TextBlock letter in stackLetters.Children)
            {
                letter.Foreground = Brushes.White;
            }
            label.Foreground = Brushes.Gold;
            showTable();
        }


        private void cmbSeason_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            showTable();
        }

        private void cmbTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            showTable();
        }

        private void txtPlayerName_TextChanged(object sender, TextChangedEventArgs e)
        {
            showTable();
        }

        private void cmbPlayname_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Button btnEdit = (Button)sender;
            var currentPlayer = btnEdit.DataContext as PlayerInTeam;
            FrameManager.mainFrame.Navigate(new PageEditOrPlayer(context, currentPlayer));
        }
    }
}
