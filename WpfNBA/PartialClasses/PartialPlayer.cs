using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfNBA
{
    public partial class Player
    {
        public int Experience 
        {
            get 
            {
                int currentVear = DateTime.Now.Year;
                int join = JoinYear.Year;
                return currentVear - join;
            }
        }
    }
}
