using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Linq;

namespace ControlNavegación
{
    public partial class menuControl : Window
    {
        private List<string> carrito = new List<string>();
        private Dictionary<string, List<string>> productosCategoria;

        public class ProductoItem
        {
            public string Name { get; set; }
        }

        public menuControl()
        {
            InitializeComponent();
            InitializeProductos();
            InitializeCategoriaComboBox();
        }

        private void InitializeProductos()
        {
            productosCategoria = new Dictionary<string, List<string>>
            {
                {"Frutas", new List<string> {
                    "Manzana", "Plátano", "Naranja", "Uva", "Fresa",
                    "Pera", "Piña", "Mango", "Kiwi", "Sandía"
                }},
                {"Carnes", new List<string> {
                    "Pollo", "Res", "Cerdo", "Pavo", "Cordero",
                    "Pescado", "Atún", "Salmón", "Camarón", "Langosta"
                }},
                {"Lacteos", new List<string> {
                    "Leche", "Queso", "Yogur", "Mantequilla", "Crema",
                    "Helado", "Queso Crema", "Requesón", "Leche Condensada", "Crema Batida"
                }},
                {"Bebidas", new List<string> {
                    "Coca-Cola", "Pepsi", "Sprite", "Fanta", "Agua",
                    "Jugo de Naranja", "Cerveza", "Vino", "Té", "Café"
                }}
            };
        }

        private void InitializeCategoriaComboBox()
        {
            categoriaComboBox.Items.Add("Seleccione Categoría");
            foreach (var categoria in productosCategoria.Keys)
            {
                categoriaComboBox.Items.Add(categoria);
            }
            categoriaComboBox.SelectedIndex = 0;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;
            string header = menuItem.Header?.ToString();

            switch (header)
            {
                case "Inicio":
                    MostrarInicio();
                    compradorPanel.Visibility = Visibility.Collapsed;
                    break;
                case "Continuar":
                    compradorPanel.Visibility = Visibility.Visible;
                    break;
                case "Nuevo":
                    NuevoCarrito();
                    compradorPanel.Visibility = Visibility.Visible;
                    break;
                case "Salir":
                    SalirAplicacion();
                    break;
                case "Frutas":
                case "Carnes":
                case "Lacteos":
                case "Bebidas":
                    MostrarProductos(header);
                    break;
            }
        }

        private void CategoriaComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            productoComboBox.Items.Clear();
            string categoriaSeleccionada = categoriaComboBox.SelectedItem.ToString();

            if (categoriaSeleccionada != "Seleccione Categoría" && productosCategoria.ContainsKey(categoriaSeleccionada))
            {
                productoComboBox.Items.Add("Seleccione Producto");
                foreach (var producto in productosCategoria[categoriaSeleccionada])
                {
                    productoComboBox.Items.Add(producto);
                }
                productoComboBox.SelectedIndex = 0;
            }
        }

        private void ProductoComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (productoComboBox.SelectedIndex > 0)
            {
                string productoSeleccionado = productoComboBox.SelectedItem.ToString();
                if (!carrito.Contains(productoSeleccionado))
                {
                    carrito.Add(productoSeleccionado);
                    ActualizarCarritoUI();
                    productoComboBox.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Este producto ya está en el carrito", "Aviso",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                    productoComboBox.SelectedIndex = 0;
                }
            }
        }

        private void RemoveFromCart_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string producto = btn.Tag.ToString();
            carrito.Remove(producto);
            ActualizarCarritoUI();
        }

        private void MostrarInicio()
        {
            LimpiarContentGrid();
            TextBlock textBlock = new TextBlock
            {
                Text = "Bienvenido a la tienda. Seleccione una categoría de productos.",
                Foreground = System.Windows.Media.Brushes.White,
                FontSize = 20,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };
            contentGrid.Children.Add(textBlock);
        }

        private void MostrarProductos(string categoria)
        {
            var productos = productosCategoria[categoria]
                .Select(p => new ProductoItem { Name = p })
                .ToList();
            productosItemsControl.ItemsSource = productos;
        }

        private void ActualizarCarritoUI()
        {
            carritoListBox.ItemsSource = null;
            carritoListBox.ItemsSource = carrito;
        }

        private void NuevoCarrito()
        {
            carrito.Clear();
            ActualizarCarritoUI();
            nombreTextBox.Clear();
            direccionTextBox.Clear();
            telefonoTextBox.Clear();
            categoriaComboBox.SelectedIndex = 0;
        }

        private void RealizarCompra_Click(object sender, RoutedEventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(nombreTextBox.Text) ||
                string.IsNullOrWhiteSpace(direccionTextBox.Text) ||
                string.IsNullOrWhiteSpace(telefonoTextBox.Text))
            {
                MessageBox.Show("Por favor complete todos los datos del comprador", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            string productos = String.Join(", ", carrito);
            MessageBox.Show(
                $"Compra realizada por: {nombreTextBox.Text}\n" +
                $"Dirección: {direccionTextBox.Text}\n" +
                $"Teléfono: {telefonoTextBox.Text}\n\n" +
                $"Productos:\n{productos}",
                "Compra Exitosa", MessageBoxButton.OK, MessageBoxImage.Information);

            NuevoCarrito();
            compradorPanel.Visibility = Visibility.Collapsed;
        }

        private void SalirAplicacion()
        {
            MessageBoxResult result = MessageBox.Show("¿Estás seguro de que quieres salir?", "Salir",
                MessageBoxButton.YesNo, MessageBoxImage.Question);
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