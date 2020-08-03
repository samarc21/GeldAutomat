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
    public partial class Retirar : Form
    {
        int cantidad = 0;
        public Retirar()
        {
            InitializeComponent();
        }

        private void btn_Cordobas_Click(object sender, EventArgs e)
        {
            seleccion_moneda();
        }
        private void btn_dolares_Click(object sender, EventArgs e)
        {
            seleccion_moneda();
        }
        public void seleccion_moneda()
        {
            btn_100.Visible = true;
            btn_200.Visible = true;
            btn_400.Visible = true;
            btn_500.Visible = true;
            btn_600.Visible = true;
            btn_800.Visible = true;
            btn_1000.Visible = true;
            btn_otro.Visible = true;
        }


        private void btn_100_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
            cantidad = 100;
        }

        private void btn_200_Click(object sender, EventArgs e)
        {
            cantidad = 200;

        }

        private void btn_400_Click(object sender, EventArgs e)
        {
            cantidad = 400;
        }

        private void btn_500_Click(object sender, EventArgs e)
        {
            cantidad = 500;
        }

        private void btn_600_Click(object sender, EventArgs e)
        {
            cantidad = 600;

        }

        private void btn_800_Click(object sender, EventArgs e)
        {
            cantidad = 800;
        }

        private void btn_1000_Click(object sender, EventArgs e)
        {
            cantidad = 1000;
        }

        private void btn_otro_Click(object sender, EventArgs e)
        {
            txt_otro.Visible = true;

        }

        private void btn_retirar_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt_otro.Text);
            if (a < 100)
            {
                MessageBox.Show("Cantidad no valida intentelo de nuevo");
            }
            if (a > 100)
            {
                cantidad = a;
                MessageBox.Show("Retiro realizado con exito");
            }

            txt_otro.Text = string.Empty;
            txt_otro.Visible = false;





            comparar();





        }

        public void comparar()
        {

        }


    }
}
