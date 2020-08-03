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
        string pin;
        string montoi;

        public Usuario()
        {
            Nombre = string.Empty;
            Pin = string.Empty;
            Montoi = string.Empty;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Pin { get => pin; set => pin = value; }
        public string Montoi { get => montoi; set => montoi = value; }
    }
}
