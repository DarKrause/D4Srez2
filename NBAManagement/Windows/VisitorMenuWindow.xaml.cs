using NBAManagement.Windows;
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

namespace NBAManagement
{
    /// <summary>
    /// Логика взаимодействия для VisitorMenuWindow.xaml
    /// </summary>
    public partial class VisitorMenuWindow : Window
    {
        public VisitorMenuWindow()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void BtnTeams_Click(object sender, RoutedEventArgs e)
        {
            TeamsMain teamsMain = new TeamsMain();
            teamsMain.Show();
            this.Close();
        }

        private void BtnPlayers_Click(object sender, RoutedEventArgs e)
        {
            PlayersMain playersMain = new PlayersMain();
            playersMain.Show();
            this.Close();
        }
    }
}
