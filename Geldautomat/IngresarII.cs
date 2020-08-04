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
    public partial class IngresarII : Form
    {
        public IngresarII()
        {
            InitializeComponent();
        }

        private void IngresarII_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }



        private void txt_loginpin_Click(object sender, EventArgs e)
        {

        }

        private void txt_user_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_Click(object sender, EventArgs e)
        {

        }


        private void txt_loginpin_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_user_Click_1(object sender, EventArgs e)
        {

        }

        private void Pin_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_ingresarLog_Click(object sender, EventArgs e)
        {
            if (txt_user.Text.TrimStart().Length == 0 || txt_loginpin.Text.Length == 0)
            {
                MessageBox.Show("ERROR: Complete todos los campos");
                return;
            }
            bool encontrado = false;
            foreach (Usuario datos in Control_Usuarios.lista_Usuario)
            {
                if (datos.Nombre == txt_user.Text && datos.Pin == txt_loginpin.Text)
                {
                    MessageBox.Show("BIENVENIDO");
                    Usuario.Visible = false;
                    btn_ingresarLog.Visible = false;
                    txt_loginpin.Visible = false;
                    txt_user.Visible = false;
                    Pin.Visible = false;
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    encontrado = true;
                    Ingresar ingre = new Ingresar();
                    ingre.TopLevel = false;
                    Controls.Add(ingre);
                    ingre.Show();

                }
            }
        }
    }
}
