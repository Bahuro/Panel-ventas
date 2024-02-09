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

namespace ControlNavegación
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
            this.KeyDown += MainWindow_KeyDown;
        }

        private void controlN_Click(object sender, RoutedEventArgs e)
        {
            controlNav cn = new controlNav();
            cn.Show();
            this.Close();

        }

        private void menu_Click(object sender, RoutedEventArgs e)
        {
            menuControl mc = new menuControl();
            mc.Show();
            this.Close();
        }
        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Escape)
            {
                Menu m = new Menu();
                m.Show();
                this.Close();
            }

        }
    }
}
