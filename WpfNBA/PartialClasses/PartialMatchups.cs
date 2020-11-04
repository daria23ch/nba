using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfNBA
{
    public partial class Matchup
    {
        public string StatusString
        {
            get
            {
                string value = "";
                switch (Status)
                {
                    case 1:
                        value = "Finished";
                        break;
                    case 0:
                        value = "Running";
                        break;
                    case -1:
                        value = "Not start";
                        break;
                    default: break;

                }
                return value;
            }
        }
        public SolidColorBrush StatusColor
        {
            get 
            {
                SolidColorBrush value = Brushes.Black;
                switch(Status)
                {
                    case 1: value = Brushes.LightGray;
                        break;
                    case 0: value = Brushes.Red;
                        break;
                    case -1: value = Brushes.LightBlue;
                        break;
                }
                return value;
            }
        }
        public string Score => Status == -1 ? "-" : Team_Away_Score + " - " + Team_Home_Score;

        public string buttonIsEnabled => Status == -1 ? "False" : "True";

    }
}
