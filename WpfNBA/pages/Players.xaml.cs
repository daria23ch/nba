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
        public Players()
        {
            InitializeComponent();
            lettersABC();
            context = new NBAShortEntities();
            cmbSeason.ItemsSource = context.Seasons.ToList();
            cmbTeam.ItemsSource = context.Teams.ToList();
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

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
                stackLetters.Children.Add(letters);
            }
        }

        private void cmbSeason_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cmbTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtPlayerName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cmbPlayname_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
