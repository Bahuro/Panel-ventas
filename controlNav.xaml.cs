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
    /// Lógica de interacción para controlNav.xaml
    /// </summary>
    public partial class controlNav : Window
    {
        public controlNav()
        {
            InitializeComponent();
            MostrarPersonas();
        }
        private void TabControl_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Aquí puedes realizar acciones específicas cuando se cambia la selección del TabControl
            if (InicioTab.IsSelected)
            {
                // Lógica para la vista de Inicio
                MostrarPersonas();
            }
            else if (ProductosTab.IsSelected)
            {
                // Lógica para la vista de Productos
                CargarProductos();
            }
            else if (ContactoTab.IsSelected)
            {
                // Lógica para la vista de Contacto
                MostrarContacto();
            }
        }

        private void MostrarPersonas()
        {
            // Lógica para mostrar 5 personas en la vista de Inicio
            List<string> personas = new List<string>
            {
                  "Dianita ",
               "Roimer",
                 "Jimmy",
               "Dayana ",
                   "Andre"
             };

            // Limpiar contenido existente y agregar nuevos elementos
            InicioTab.Content = new System.Windows.Controls.ListBox { ItemsSource = personas };
        }

        private void CargarProductos()
        {
            // Lógica para cargar los productos en la vista de Productos
            // Por ejemplo, puedes cargar datos de una base de datos o una lista predefinida
            List<Producto> productos = new List<Producto>
 {
        new Producto { Nombre = "Hydra-Lip Brillo Labial", Precio = 39.50 },
        new Producto { Nombre = "Total Block Jumbo SPF 100", Precio = 65 },
        new Producto { Nombre = "Ccori Crsital Rose", Precio = 95.50 },
        new Producto { Nombre = "Desmaquillador Doble Fase", Precio = 37.50 },
        new Producto { Nombre = "Mascarilla Antiarrugas y Antiedad", Precio = 14 },
        new Producto { Nombre = "Totallist Aclarante Concha de nacar", Precio = 28.50 },
     // Agrega más productos según sea necesario
 };

            // Limpiar contenido existente y agregar un DataGrid con los productos
            ProductosTab.Content = new System.Windows.Controls.DataGrid { ItemsSource = productos };
        }

        private void MostrarContacto()
        {
            // Lógica para mostrar información de contacto en la vista de Contacto
            string numeroContacto = "+123456789"; // Número de contacto ficticio

            // Limpiar contenido existente y agregar un TextBlock con el número de contacto
            ContactoTab.Content = new System.Windows.Controls.TextBlock { Text = $"Para contactarnos, llame al: {numeroContacto}" };
        }

        // Clase de ejemplo para representar un Producto
        public class Producto
        {
            public string Nombre { get; set; }
            public double Precio { get; set; }
        }

    }
}
