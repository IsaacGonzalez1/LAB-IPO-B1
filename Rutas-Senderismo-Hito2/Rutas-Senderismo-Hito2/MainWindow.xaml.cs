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

        Usuarios admin = new Usuarios("Isaac", "Gonzalez", "admin1", "admin1","isaac.gonzalez1@alu.uclm.es");

        //private Usuarios admin2 = new Usuarios("Natalia", "Jimenez", "admin2", "admin2");

        public MainWindow()
        {
            InitializeComponent();
            lbl_incorrectocampos.Visibility = Visibility.Hidden;
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }




        private void CheckBoxContraseña_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)CheckBoxContraseña.IsChecked)
            {
                txtContraseña.Text = ContraseñaBox.Password;
                txtContraseña.Visibility = Visibility.Visible;
                txtContraseña.IsEnabled = false;
                ContraseñaBox.Visibility = Visibility.Hidden;

            }
            else
            {
                txtContraseña.Visibility = Visibility.Hidden;
                ContraseñaBox.Visibility = Visibility.Visible;
            }
        }

        private void ContraseñaBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                btnLogin_Click(sender, e);
            }

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsuario.Text.Equals(admin.Usuario) && ContraseñaBox.Password.Equals(admin.Contrasena))
            {
                //MessageBox.Show("ha furulado");
                Menu menu = new Menu(admin);
                menu.Show();
                Visibility = Visibility.Hidden;
                lbl_incorrectocampos.Visibility = Visibility.Hidden;

                //Menu.Show();
            }
            else
            {
                lbl_incorrectocampos.Visibility = Visibility.Visible;
                ContraseñaBox.Password = "";
                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }

        }


       
    }
}
