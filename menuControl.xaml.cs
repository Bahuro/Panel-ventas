using System;
using System.Collections.Generic;
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
                        MostrarInicio();
                        break;
                    case "Productos":
                        
                        break;
                    case "Carrito de Compras":
                        MostrarCarrito();
                        break;
                    case "Salir":
                        SalirAplicacion();
                        break;
                    default:
                        
                        MostrarProductos(header);
                        break;
                }
            }
        }

        private void MostrarInicio()
        {
            LimpiarContentGrid();
            contentGrid.Children.Add(new TextBlock() { Text = "Estás en la página de Inicio." });
        }

        private void MostrarProductos(string categoria)
        {
            LimpiarContentGrid();
            List<string> productos = ObtenerProductosPorCategoria(categoria);
            ListBox listBoxProductos = new ListBox();
            foreach (string producto in productos)
            {
                listBoxProductos.Items.Add(producto);
            }
            contentGrid.Children.Add(listBoxProductos);
        }

        private List<string> ObtenerProductosPorCategoria(string categoria)
        {
            switch (categoria)
            {
               
                case "Frutas":
                    return new List<string> { "Manzana", "Plátano", "Naranja", "Uva", "Fresa", "Pera", "Piña", "Mango", "Kiwi", "Cereza", "Melón", "Sandía", "Limón", "Mandarina", "Papaya", "Granada", "Ciruela", "Higo", "Dátil", "Coco", "Guayaba", "Maracuyá", "Tamarindo", "Lichi", "Pomelo", "Mora", "Fruta de la pasión", "Carambola", "Kumquat", "Níspero", "Chirimoya", "Caqui", "Membrillo", "Zarzamora", "Pitahaya", "Nectarina", "Castaña", "Cereza de Barbados", "Naranja sanguina", "Melocotón", "Níspero japonés", "Tamarillo", "Feijoa", "Rambután", "Tuna", "Grosella", "Ciruela pasa", "Yuzu", "Jabuticaba", "Noni" };
               
               
                default:
                    return new List<string>(); // Retorna una lista vacía si no se encuentra la categoría
            }
        }

        private void MostrarCarrito()
        {
            LimpiarContentGrid();
            contentGrid.Children.Add(new TextBlock() { Text = "Tu carrito de compras está vacío." });
        }

        private void SalirAplicacion()
        {
            MessageBoxResult result = MessageBox.Show("¿Estás seguro de que quieres salir?", "Salir", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void LimpiarContentGrid()
        {
            contentGrid.Children.Clear();
        }
    }
}
