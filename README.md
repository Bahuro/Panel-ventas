# Tienda WPF - Sistema de Gestión de Ventas

## 📝 Descripción
Sistema de gestión de ventas desarrollado en WPF (Windows Presentation Foundation) que permite la visualización de productos por categorías y gestión de carritos de compra. La aplicación está diseñada con una interfaz intuitiva y fácil de usar, implementando un sistema de menú navegable y gestión de datos del comprador.

## 🚀 Características Principales

### Menú de Navegación
- **Inicio**: Página de bienvenida
- **Productos**: Categorías disponibles
  - Frutas
  - Carnes
  - Lácteos
  - Bebidas
- **Carrito**
  - Continuar compra
  - Nuevo carrito
- **Salir**: Opción para cerrar la aplicación

### Visualización de Productos
- Listado vertical de productos por categoría
- Interfaz limpia y organizada
- Productos claramente identificables
- Visualización optimizada con scroll

### Sistema de Carrito
- Selección de productos por categoría
- Añadir/eliminar productos
- Evita duplicados automáticamente
- Lista de productos seleccionados
- Gestión de datos del comprador:
  - Nombre
  - Dirección
  - Teléfono

## 🛠️ Tecnologías Utilizadas
- C# como lenguaje de programación
- WPF para la interfaz gráfica
- XAML para el diseño de la interfaz
- .NET Framework

## 📋 Requisitos del Sistema
- Windows 7 o superior
- .NET Framework 4.7.2 o superior
- Resolución de pantalla mínima recomendada: 1024x768

## 🔧 Instalación
1. Clonar el repositorio
```bash
https://github.com/Bahuro/Panel-ventas.git
```
2. Abrir la solución en Visual Studio
3. Compilar el proyecto
4. Ejecutar la aplicación

## 💻 Uso
1. **Iniciar la Aplicación**
   - Ejecutar el archivo .exe generado
   - Se mostrará la pantalla de inicio

2. **Visualizar Productos**
   - Seleccionar "Productos" en el menú
   - Elegir una categoría
   - Los productos se mostrarán en formato lista

3. **Gestionar Carrito**
   - Seleccionar "Carrito" > "Nuevo" para iniciar compra
   - Usar los desplegables para seleccionar categoría y producto
   - Eliminar productos con el botón "X"
   - Completar datos del comprador
   - Finalizar compra

## 🔍 Estructura del Proyecto
```
├── menuControl.xaml           # Interfaz principal
├── menuControl.xaml.cs        # Lógica de la aplicación
├── App.xaml                   # Configuración de la aplicación
└── Resources/                 # Recursos (imágenes, iconos)
```

## ✨ Características Adicionales
- Validación de datos del comprador
- Mensajes informativos para el usuario
- Confirmación antes de salir
- Prevención de duplicados en el carrito
- Interfaz responsive

## 🤝 Contribución
Las contribuciones son bienvenidas. Para contribuir:
1. Fork el proyecto
2. Crea tu rama de características
3. Commit tus cambios
4. Push a la rama
5. Abre un Pull Request

## 📄 Licencia
Este proyecto está bajo la Licencia MIT - Ver el archivo [LICENSE.md](LICENSE) para más detalles.

## ✉️ Contacto
Juan Roimer Bautista Huingo - bautistahuingojuanroimer@gmail.com

Link del proyecto: https://github.com/Bahuro/Panel-ventas
