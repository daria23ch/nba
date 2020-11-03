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
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
            NBAShortEntities context = new NBAShortEntities();
            listViewImages.ItemsSource = context.Pictures.ToList();
        }

        private void btnVisitor_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.mainFrame.Navigate(new Visitor());
        }

        private void btnAdmin_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("in development");
        }
    }
}
