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
    /// Логика взаимодействия для TeamsMain.xaml
    /// </summary>
    public partial class TeamsMain : Window
    {
        public TeamsMain()
        {
            InitializeComponent();
            LViewTeamsWest.ItemsSource = Database.DataBase.Team.ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            VisitorMenuWindow teamsMain = new VisitorMenuWindow();
            teamsMain.Show();
            this.Close();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
