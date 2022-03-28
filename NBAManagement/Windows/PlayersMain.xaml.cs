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
using System.Windows.Shapes;

namespace NBAManagement.Windows
{
    /// <summary>
    /// Логика взаимодействия для PlayersMain.xaml
    /// </summary>
    public partial class PlayersMain : Window
    {
        public PlayersMain()
        {
            InitializeComponent();
            dgPlayer.ItemsSource = Database.DataBase.Player.ToList();
        }
    }
}
