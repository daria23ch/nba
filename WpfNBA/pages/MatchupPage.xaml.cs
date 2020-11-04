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
    /// Логика взаимодействия для MatchupPage.xaml
    /// </summary>
    public partial class MatchupPage : Page
    {
        public MatchupPage()
        {
            InitializeComponent();
            NBAShortEntities context = new NBAShortEntities();
            itemsControlMatchUps.ItemsSource = context.Matchups.ToList();
        }

        private void btnButton_Click(object sender, RoutedEventArgs e)
        {
            Button btnButton = (Button)sender;
            Matchup currentMatchup = (Matchup)btnButton.DataContext;
            stackMatchupMain.DataContext = currentMatchup;
        }
    }
}
