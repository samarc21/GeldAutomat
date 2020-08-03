using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geldautomat
{
    class Control_Usuarios
    {
        public static List<Usuario> lista_Usuario = new List<Usuario>();
        public Control_Usuarios()
        {
            lista_Usuario = new List<Usuario>();
        }
        public static void agregar_user(Usuario a)
        {
            lista_Usuario.Add(a);
        }
    }
}
