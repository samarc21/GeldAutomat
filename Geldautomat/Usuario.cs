using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geldautomat
{
    class Usuario
    {
        string nombre;
        string ping;
        string montoi;

        public Usuario()
        {
            Nombre = string.Empty;
            Ping = string.Empty;
            Montoi = string.Empty;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Ping { get => ping; set => ping = value; }
        public string Montoi { get => montoi; set => montoi = value; }
    }
}
