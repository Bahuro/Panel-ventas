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
    public partial class controlNav : Window
    {
        public controlNav()
        {
            InitializeComponent();
            MostrarPersonas();
            this.KeyDown += MainWindow_KeyDown;

        }
        private void TabControl_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            
            if (InicioTab.IsSelected)
            {
                
                MostrarPersonas();
            }
            else if (ProductosTab.IsSelected)
            {
               
                CargarProductos();
            }
            else if (ContactoTab.IsSelected)
            {
                
                MostrarContacto();
            }
        }

        private void MostrarPersonas()
        {
          
            List<string> personas = new List<string>
            {
                  "Dianita ",
               "Roimer",
                 "Jimmy",
               "Dayana ",
                   "Andre"
             };

          
            InicioTab.Content = new System.Windows.Controls.ListBox { ItemsSource = personas };
        }

        private void CargarProductos()
        {
            List<Producto> productos = new List<Producto>
 {
        new Producto { NombreP = "Hydra-Lip Brillo Labial", Precio = 39.50 },
        new Producto { NombreP = "Total Block Jumbo SPF 100", Precio = 65 },
        new Producto { NombreP = "Ccori Crsital Rose", Precio = 95.50 },
        new Producto { NombreP = "Desmaquillador Doble Fase", Precio = 37.50 },
        new Producto { NombreP = "Mascarilla Antiarrugas y Antiedad", Precio = 14 },
        new Producto { NombreP = "Totallist Aclarante Concha de nacar", Precio = 28.50 },
        new Producto { NombreP = "Mascarilla Antiarrugas y Antiedad", Precio = 14 },
        new Producto { NombreP = "Totallist Aclarante Concha de nacar", Precio = 28.50 },
   
 };

            
            ProductosTab.Content = new System.Windows.Controls.DataGrid { ItemsSource = productos };
        }


        private void MostrarContacto()
        {
            
            List<Contacto> contactito = new List<Contacto>
            {
                 new Contacto {NombreC = "JUAN ", Numero = "+51 945037467"  },
               
             };

            ContactoTab.Content = new System.Windows.Controls.DataGrid { ItemsSource = contactito};
        }
    
       

        public class Producto
        {
            public string NombreP { get; set; }
            public double Precio { get; set; }
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

        public class Contacto
        {
            public string NombreC { get; set; }
            public   String Numero { get; set; }
        }

    }
}
