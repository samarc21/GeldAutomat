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
    public partial class Ingresar : Form
    {
        public Ingresar()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (pnl_input_ingresar.Controls.Count > 0)
            {
                pnl_input_ingresar.Controls.Clear();
            }
            IngresarII ingresarii = new IngresarII();
            ingresarii.TopLevel = false;
            pnl_input_ingresar.Controls.Add(ingresarii);
            ingresarii.Show();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (pnl_input_ingresar.Controls.Count > 0)
            {
                pnl_input_ingresar.Controls.Clear();
            }
            Consultar consulta = new Consultar();
            consulta.TopLevel = false;
            pnl_input_ingresar.Controls.Add(consulta);
            consulta.Show();
        }

        private void btn_retirar_Click(object sender, EventArgs e)
        {
            if (pnl_input_ingresar.Controls.Count > 0)
            {
                pnl_input_ingresar.Controls.Clear();
            }
            Retirar retiro = new Retirar();
            retiro.TopLevel = false;
            pnl_input_ingresar.Controls.Add(retiro);
            retiro.Show();
        }
    }
}
