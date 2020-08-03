namespace Geldautomat
{
    partial class Ingresar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_opciones = new System.Windows.Forms.Panel();
            this.txt_consultar = new MetroFramework.Controls.MetroButton();
            this.txt_retirar = new MetroFramework.Controls.MetroButton();
            this.btn_ingresar = new MetroFramework.Controls.MetroButton();
            this.pnl_input_ingresar = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnl_opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.75F));
            this.tableLayoutPanel1.Controls.Add(this.pnl_opciones, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnl_input_ingresar, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 554);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnl_opciones
            // 
            this.pnl_opciones.Controls.Add(this.txt_consultar);
            this.pnl_opciones.Controls.Add(this.txt_retirar);
            this.pnl_opciones.Controls.Add(this.btn_ingresar);
            this.pnl_opciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_opciones.Location = new System.Drawing.Point(4, 4);
            this.pnl_opciones.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_opciones.Name = "pnl_opciones";
            this.pnl_opciones.Size = new System.Drawing.Size(240, 546);
            this.pnl_opciones.TabIndex = 0;
            // 
            // txt_consultar
            // 
            this.txt_consultar.Location = new System.Drawing.Point(60, 188);
            this.txt_consultar.Name = "txt_consultar";
            this.txt_consultar.Size = new System.Drawing.Size(91, 23);
            this.txt_consultar.TabIndex = 5;
            this.txt_consultar.Text = "Consultar";
            this.txt_consultar.Click += new System.EventHandler(this.txt_consultar_Click);
            // 
            // txt_retirar
            // 
            this.txt_retirar.Location = new System.Drawing.Point(60, 217);
            this.txt_retirar.Name = "txt_retirar";
            this.txt_retirar.Size = new System.Drawing.Size(91, 23);
            this.txt_retirar.TabIndex = 4;
            this.txt_retirar.Text = "Retirar";
            this.txt_retirar.Click += new System.EventHandler(this.txt_retirar_Click);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(60, 159);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(91, 23);
            this.btn_ingresar.TabIndex = 3;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click_1);
            // 
            // pnl_input_ingresar
            // 
            this.pnl_input_ingresar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_input_ingresar.Location = new System.Drawing.Point(252, 4);
            this.pnl_input_ingresar.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_input_ingresar.Name = "pnl_input_ingresar";
            this.pnl_input_ingresar.Size = new System.Drawing.Size(811, 546);
            this.pnl_input_ingresar.TabIndex = 1;
            // 
            // Ingresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ingresar";
            this.Text = "Ingresar";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnl_opciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnl_opciones;
        private System.Windows.Forms.Panel pnl_input_ingresar;
        private MetroFramework.Controls.MetroButton txt_consultar;
        private MetroFramework.Controls.MetroButton txt_retirar;
        private MetroFramework.Controls.MetroButton btn_ingresar;
    }
}