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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rutas_Senderismo_Hito2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Usuarios admin = new Usuarios("Isaac", "Gonzalez", "admin1", "admin1");
        private Usuarios admin2 = new Usuarios("Natalia", "Jimenez", "admin2", "admin2");
        private BitmapImage imagCheck = new BitmapImage(new Uri("/Imagenes/check.png", UriKind.Relative));
        private BitmapImage imagCross = new BitmapImage(new Uri("/Imagenes/cross.png", UriKind.Relative));
        //arreglar source de las imágenes
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {

                if (!String.IsNullOrEmpty(txtUsuario.Text)
                && (ComprobarEntrada(txtUsuario.Text, admin.Usuario,
                txtUsuario, imgCheckUsuario) || ComprobarEntrada(txtUsuario.Text, admin2.Usuario,
                txtUsuario, imgCheckUsuario) ))
                {
                    // habilitar entrada de contraseña y pasarle el foco
                    ContraseñaBox.IsEnabled = true;
                    ContraseñaBox.Focus();
                    // deshabilitar entrada de login
                    txtUsuario.IsEnabled = false;
                }
            }

        }


        private Boolean ComprobarEntrada(string valorIntroducido, string valorValido, Control componenteEntrada, Image imagenFeedBack)
        {
            Boolean valido = false;
            componenteEntrada.BorderThickness = new Thickness(2);
            if (valorIntroducido.Equals(valorValido))
            {
                // borde y background en verde
                componenteEntrada.BorderBrush = Brushes.Green;
                componenteEntrada.Background = Brushes.LightGreen;
                // imagen al lado de la entrada de usuario --> check
                imagenFeedBack.Source = imagCheck;
                valido = true;
            }
            else
            {
                // marcamos borde en rojo
                componenteEntrada.BorderBrush = Brushes.Red;
                // imagen al lado de la entrada de usuario --> cross
                imagenFeedBack.Source = imagCross;
                valido = false;
            }
            return valido;
        }
    }
}
