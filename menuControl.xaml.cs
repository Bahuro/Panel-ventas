using System.Windows;
using System.Windows.Controls;

namespace ControlNavegación
{
    public partial class menuControl : Window
    {
        public menuControl()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;
            string header = menuItem.Header?.ToString();

            if (header != null)
            {
                switch (header)
                {
                    case "Inicio":
                        contentGrid.Children.Clear();
                        contentGrid.Children.Add(new TextBlock() { Text = "Estás en la página de Inicio." });
                        break;
                    case "Productos":
                        contentGrid.Children.Clear();
                        contentGrid.Children.Add(new TextBlock() { Text = "Aquí están los productos disponibles." });
                        break;
                    case "Carrito de Compras":
                        contentGrid.Children.Clear();
                        contentGrid.Children.Add(new TextBlock() { Text = "Tu carrito de compras está vacío." });
                        break;
                    case "Salir":
                        
                        break;
                }
            }
        }

    }
}
