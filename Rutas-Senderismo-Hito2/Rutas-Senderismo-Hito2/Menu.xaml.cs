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

namespace Rutas_Senderismo_Hito2
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        //meter ruta imagen o meterla en la de usuarios
        public string fechaActual= DateTime.Now.ToString();
        private BitmapImage Imagen = new BitmapImage(new Uri("/Imagenes/foto usuario.jpg", UriKind.Relative));
        public Menu(Usuarios u)
        {
            InitializeComponent();
            lbl_infoNombre.Content = u.Nombre;//cargar información
            lbl_infoApellidos.Content = u.Apellido;
            lbl_infoContacto.Content = u.Contacto;
            lbl_infoUltimoAcceso.Content = fechaActual;
            UsuarioImagen.Source = Imagen;

            
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
