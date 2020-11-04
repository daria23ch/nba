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
    /// Логика взаимодействия для PageEditOrPlayer.xaml
    /// </summary>
    public partial class PageEditOrPlayer : Page
    {
        NBAShortEntities context;
        public PageEditOrPlayer(NBAShortEntities context, PlayerInTeam currentPlayer)
        {
            InitializeComponent();
            this.context = context;
            this.DataContext = currentPlayer;
            cmbPlayer.ItemsSource = context.Players.ToList();
            cmbTeam.ItemsSource = context.Teams.ToList();
            cmbSeason.ItemsSource = context.Seasons.ToList();

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
            FrameManager.mainFrame.Navigate(new Players());
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.mainFrame.Navigate(new Players());
        }
    }
}
