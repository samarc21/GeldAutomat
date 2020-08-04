using Microsoft.Win32;
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

        private void btn_comReg_Click_1(object sender, EventArgs e)
        {
           


        }

        private void Registrar_Load(object sender, EventArgs e)
        {

        }

        private void txt_montoinicial_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txt_nombre_Click(object sender, EventArgs e)
        {

        }

        private void btn_comReg_Click(object sender, EventArgs e)
        {
            Usuario a = new Usuario();
            // if ()

            if ((txt_pin.Text == txt_confPin.Text) && (txt_pin.Text.TrimStart().Length != 0) && (txt_confPin.Text.Length != 0))
            {

                a.Nombre = txt_nombre.Text;
                a.Montoi = txt_montoinicial.Text;
                a.Pin = txt_pin.Text;
                Control_Usuarios.lista_Usuario.Add(a);
                MessageBox.Show("Se ha registrado");
                pnl_registro.Controls.Clear();

            }


            //}
            else
            {

                MessageBox.Show("ERROR: Asegurese que su PIN ha sido ingresado correctamente");
                txt_pin.Clear();
                txt_confPin.Clear();
            }
        }
    }
}
