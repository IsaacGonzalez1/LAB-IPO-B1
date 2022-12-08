using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rutas_Senderismo_Hito2
{
    public class Usuarios
    {
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Usuario { set; get; }
        public string Contrasena { set; get; }

        public string Contacto { set; get; }
        public Usuarios(string nombre, string apellido, string usuario, string contrasena, string contacto)
        {
            Nombre = nombre;
            Apellido = apellido;
            Usuario = usuario;
            Contrasena = contrasena;
            Contacto = contacto;
        }





    }
}
