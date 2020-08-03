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

        }

        private void btn_200_Click(object sender, EventArgs e)
        {

        }

        private void btn_400_Click(object sender, EventArgs e)
        {

        }

        private void btn_500_Click(object sender, EventArgs e)
        {

        }

        private void btn_600_Click(object sender, EventArgs e)
        {

        }

        private void btn_800_Click(object sender, EventArgs e)
        {

        }

        private void btn_1000_Click(object sender, EventArgs e)
        {

        }

        private void btn_otro_Click(object sender, EventArgs e)
        {

        }
    }
}
