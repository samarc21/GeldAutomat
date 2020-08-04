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
        int moneda = 0;
        int a = 10, b = 10, c = 13, d = 24;     //cordobas
        int e = 100, f = 100, g = 80, h = 100, i = 60;
        int cont = 0;
       

        public Retirar()
        {
            InitializeComponent();
            txt_otro.Visible = false;
        }

      /*  private void btn_Cordobas_Click(object sender, EventArgs e)
        {
            
        }*/
        /*private void btn_dolares_Click_1(object sender, EventArgs e)
        {
            
        }*/
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


      /*  private void btn_100_Click(object sender, EventArgs e)
        {
            

        }*/

       /* private void btn_200_Click(object sender, EventArgs e)
        {
            


        }*/
        /*private void btn_400_1_Click(object sender, EventArgs e)
        {
           

        }*/



        /*private void btn_500_Click(object sender, EventArgs e)
        {
            


        }*/

       /* private void btn_600_Click(object sender, EventArgs e)
        {
            


        }*/

        /*private void btn_800_Click(object sender, EventArgs e)
        {
            


        }*/

       /* private void btn_1000_Click(object sender, EventArgs e)
        {
            
        }*/

      /*  private void btn_otro_Click(object sender, EventArgs e)
        {
            

        }*/

       public void comparar()
                            //contador de billetes
        {
            int ca=0, cb=0, cc=0, cd=0, ce=0, cf=0, cg=0,ch=0, ci= 0;
            switch (moneda)
            {
         
                case 1:                 //cordobas
                    if (cantidad >= 1000)
                    {
                        cont = cont - 1000;
                        cantidad = cantidad - 1000;
                        a = a - 1;
                        ca = +1;
                    }
                    if (cantidad >= 500)
                    {
                        cont = cont - 500;
                        cantidad = cantidad - 500;
                        b = b - 1;
                        cb = +1;
                    }
                    if (cantidad >= 200)
                    {
                        cont = cont - 200;
                        cantidad = cantidad - 200;
                        c = c - 1;
                        cc = +1;
                    }
                    if (cantidad >= 100)
                    {
                        cont = cont - 100;
                        cantidad = cantidad - 100;
                        d = d - 1;
                        cd = +1;
                    }
                    break;


                case 2:                             //dolares
                    if (cantidad >= 100)
                    {
                        cont = cont - 100;
                        cantidad = cantidad - 100;
                        e = e - 1;
                        ce = +1;
                    }
                    if (cantidad >= 50)
                    {
                        cont = cont - 50;
                        cantidad = cantidad - 50;
                        f = f - 1;
                        cf = +1;
                    }
                    if (cantidad >= 30)
                    {
                        cont = cont - 30;
                        cantidad = cantidad - 30;
                        g = g - 1;
                        cg = +1;
                    }
                    if (cantidad >= 20)
                    {
                        cont = cont - 20;
                        cantidad = cantidad - 20;
                        h = h - 1;
                        ch = +1;
                    }
                    if (cantidad >= 10)
                    {
                        cont = cont - 10;
                        cantidad = cantidad - 10;
                        i = i - 1;
                        ci = +1;
                    }


                    break;

            }
        }

        /*private void btn_retirar_Click_1(object sender, EventArgs e)
        {
          
        }*/

        private void btn_Cordobas_Click_1(object sender, EventArgs e)
        {
            seleccion_moneda();
        }

        private void btn_Dolares_Click(object sender, EventArgs e)
        {
            seleccion_moneda();
        }

        private void btn_100_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Retiro realizado con exito");
            cantidad = 100;
            pnl_retirar.Controls.Clear();
        }

        private void btn_200_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Retiro realizado con exito");
            cantidad = 200;
            pnl_retirar.Controls.Clear();
        }

        private void btn_400_Click(object sender, EventArgs e)
        {
            cantidad = 400;
            MessageBox.Show("Retiro realizado con exito");
            pnl_retirar.Controls.Clear();
        }

        private void btn_500_Click_1(object sender, EventArgs e)
        {
            cantidad = 500;
            MessageBox.Show("Retiro realizado con exito");
            pnl_retirar.Controls.Clear();
        }

        private void btn_600_Click_1(object sender, EventArgs e)
        {
            cantidad = 600;
            MessageBox.Show("Retiro realizado con exito");
            pnl_retirar.Controls.Clear();

        }

        private void btn_800_Click_1(object sender, EventArgs e)
        {
            cantidad = 800;
            MessageBox.Show("Retiro realizado con exito");
            pnl_retirar.Controls.Clear();
        }

        private void btn_1000_Click_1(object sender, EventArgs e)
        {
            cantidad = 1000;
            MessageBox.Show("Retiro realizado con exito");
            pnl_retirar.Controls.Clear();

        }

        private void btn_otro_Click_1(object sender, EventArgs e)
        {
            txt_otro.Visible = true;
            btn_retirar.Visible = true;
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
                pnl_retirar.Controls.Clear();

            }

            txt_otro.Text = string.Empty;
            txt_otro.Visible = false;





            comparar();
        }
    }
}
