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
                    return new List<string> { "Manzana", "Plátano", "Naranja", "Uva", "Fresa", "Pera", "Piña", "Mango", "Kiwi", "Cereza", 
                                              "Melón", "Sandía", "Limón", "Mandarina", "Papaya", "Granada", "Ciruela", "Higo", "Dátil", "Coco", 
                                              "Guayaba", "Maracuyá", "Tamarindo", "Lichi", "Pomelo", "Mora", "Fruta de la pasión", "Carambola", 
                                              "Kumquat", "Níspero", "Chirimoya", "Caqui", "Membrillo", "Zarzamora", "Pitahaya", "Nectarina", "Castaña",
                                              "Cereza de Barbados", "Naranja sanguina", "Melocotón", "Níspero japonés", "Tamarillo", "Feijoa", "Rambután", 
                                              "Tuna", "Grosella", "Ciruela pasa", "Yuzu", "Jabuticaba", "Noni" };
                case "Carnes":

                    return new List<string> { "Pollo", "Res", "Cerdo", "Pavo", "Cordero", "Pato", "Ternera", "Codorniz", "Conejo", "Liebre",
                                              "Faisán", "Ciervo", "Búfalo", "Jabalí", "Carnero", "Cabra", "Avestruz", "Pichón", "Paloma", "Ganso", "Salmón", "Atún",
                                              "Trucha", "Bacalao", "Lenguado", "Merluza", "Sardina", "Anchoa", "Bacalao", "Anguila", "Pejerrey", "Dorada", "Mero",
                                              "Besugo", "Pez espada", "Tilapia", "Carpa", "Róbalo", "Calamar", "Pulpo", "Langosta", "Cangrejo", "Almeja", "Mejillón",
                                              "Ostra", "Caracol", "Chorizo", "Salchicha", "Jamón" };
                case "Lacteos":

                    return new List<string> { "Leche", "Queso", "Yogur", "Mantequilla", "Nata", "Helado", "Postres lácteos", "Leche condensada", 
                                              "Leche evaporada", "Leche en polvo", "Kéfir", "Crema agria", "Requesón", "Cuajada", "Queso crema", 
                                              "Ricotta", "Mozzarella", "Gruyère", "Roquefort", "Brie", "Camembert", "Feta", "Provolone", "Gouda", "Emmental", "Manchego", 
                                              "Parmesano", "Cheddar", "Gorgonzola", "Cottage cheese", "Mascarpone", "Crema de queso azul", 
                                              "Leche de cabra", "Leche de oveja", "Leche de búfala", "Yogur griego", "Yogur de frutas", "Yogur natural", 
                                              "Yogur desnatado", "Yogur sin lactosa", "Helado de vainilla", "Helado de chocolate", "Helado de fresa", 
                                              "Helado de vainilla con trozos de galleta", "Helado de pistacho", "Helado de nueces", "Flan de vainilla" };
                case "Bebidas":

                    return new List<string> { "Coca-Cola", "Pepsi", "Sprite", "Fanta", "7Up", "Mirinda", "Dr Pepper", "Mountain Dew", "Schweppes", 
                                              "Canada Dry", "Cerveza Corona", "Heineken", "Budweiser", "Guinness", "Stella Artois", "Modelo", "Victoria", 
                                              "Tecate", "Dos Equis", "Red Bull", "Monster Energy", "Rockstar Energy", "Gatorade", "Powerade", "Arizona", 
                                              "Snapple", "Nestea", "Lipton Ice Tea", "Tropicana", "Minute Maid", "Del Valle", "Fruitopia", "Ciel", 
                                              "Bonafont", "Dasani", "San Pellegrino", "Perrier", "Evian", "Aquafina", "Volvic", "Topo Chico", "Jarritos", 
                                              "Fresca", "Squirt", "A&W Root Beer", "Barq's", "Sunkist", "Canada Dry Ginger Ale" };

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
