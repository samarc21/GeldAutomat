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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
           
        }

        private void btn_x_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        /*private void btn_ingresar_Click(object sender, EventArgs e)
        {
            

        }*/
        
       /* private void btn_registrarse_Click(object sender, EventArgs e)
        {
            
           
            
           
        }*/

        private void btn_registrarse_Click_1(object sender, EventArgs e)
        {
            if (pnl_input.Controls.Count > 0)
            {
                pnl_input.Controls.Clear();
            }
            Registrar registro = new Registrar();
            registro.TopLevel = false;
            pnl_input.Controls.Add(registro);
            registro.Show();


        }

        private void btn_ingresar_Click_1(object sender, EventArgs e)
        {
            if (pnl_input.Controls.Count > 0)
            {
                pnl_input.Controls.Clear();
            }
            Ingresar ingresar = new Ingresar();
            ingresar.TopLevel = false;
            pnl_input.Controls.Add(ingresar);
            ingresar.Show();
        }
    }
}
