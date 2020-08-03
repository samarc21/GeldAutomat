using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geldautomat
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void btn_comReg_Click(object sender, EventArgs e)
        {
            Usuario a = new Usuario();
           // if ()
            
                if ((txt_pin.Text == txt_confPin.Text) && (txt_pin.Text.TrimStart().Length != 0 )&& (txt_confPin.Text.Length != 0))
                {

                    a.Nombre = txt_nombre.Text;
                    a.Montoi = txt_montoinicial.Text;
                    a.Pin = txt_pin.Text;
                    MessageBox.Show("Se ha registrado");
                }
                

            //}
            else {

                MessageBox.Show("ERROR: Asegurese que su PIN ha sido ingresado correctamente");
                txt_pin.Clear();
                txt_confPin.Clear();
            }

        }
    }
}
