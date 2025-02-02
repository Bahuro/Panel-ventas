using System.Windows;
using System.Windows.Input;

namespace ControlNavegación
{
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

        private void cerrarAppButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
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