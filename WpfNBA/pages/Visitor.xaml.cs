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
    /// Логика взаимодействия для Visitor.xaml
    /// </summary>
    public partial class Visitor : Page
    {
        public Visitor()
        {
            InitializeComponent();
        }

        private void btnTeams_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("in development");
        }

        private void btnPlayers_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.mainFrame.Navigate(new Players());
        }

        private void btnMatchup_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.mainFrame.Navigate(new MatchupPage());
        }

        private void btnPhotos_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("in development");
        }
    }
}
