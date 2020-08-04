namespace Geldautomat
{
    partial class Dashboard
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_bienvenido = new System.Windows.Forms.Panel();
            this.btn_x = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_registrarse = new MetroFramework.Controls.MetroButton();
            this.btn_ingresar = new MetroFramework.Controls.MetroButton();
            this.pnl_input = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnl_bienvenido.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnl_bienvenido, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 86);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnl_bienvenido
            // 
            this.pnl_bienvenido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_bienvenido.Controls.Add(this.pictureBox1);
            this.pnl_bienvenido.Controls.Add(this.btn_x);
            this.pnl_bienvenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_bienvenido.Location = new System.Drawing.Point(4, 4);
            this.pnl_bienvenido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_bienvenido.Name = "pnl_bienvenido";
            this.pnl_bienvenido.Size = new System.Drawing.Size(1059, 78);
            this.pnl_bienvenido.TabIndex = 0;
            // 
            // btn_x
            // 
            this.btn_x.BackColor = System.Drawing.Color.Red;
            this.btn_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_x.ForeColor = System.Drawing.Color.White;
            this.btn_x.Location = new System.Drawing.Point(1002, 4);
            this.btn_x.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_x.Name = "btn_x";
            this.btn_x.Size = new System.Drawing.Size(48, 26);
            this.btn_x.TabIndex = 1;
            this.btn_x.Text = "X";
            this.btn_x.UseVisualStyleBackColor = false;
            this.btn_x.Click += new System.EventHandler(this.btn_x_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.125F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.875F));
            this.tableLayoutPanel2.Controls.Add(this.pnl_menu, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnl_input, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 86);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1067, 468);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pnl_menu
            // 
            this.pnl_menu.Controls.Add(this.btn_registrarse);
            this.pnl_menu.Controls.Add(this.btn_ingresar);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_menu.Location = new System.Drawing.Point(4, 4);
            this.pnl_menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(153, 460);
            this.pnl_menu.TabIndex = 0;
            // 
            // btn_registrarse
            // 
            this.btn_registrarse.Location = new System.Drawing.Point(45, 214);
            this.btn_registrarse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_registrarse.Name = "btn_registrarse";
            this.btn_registrarse.TabIndex = 3;
            this.btn_registrarse.Text = "Registrar";
            this.btn_registrarse.Click += new System.EventHandler(this.btn_registrarse_Click_1);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(31, 169);
            this.btn_ingresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(101, 23);
            this.btn_ingresar.TabIndex = 2;
            this.btn_ingresar.Text = "Iniciar sesion";
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click_1);
            // 
            // pnl_input
            // 
            this.pnl_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_input.Location = new System.Drawing.Point(165, 4);
            this.pnl_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_input.Name = "pnl_input";
            this.pnl_input.Size = new System.Drawing.Size(898, 460);
            this.pnl_input.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(327, -20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnl_bienvenido.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnl_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnl_bienvenido;
        private System.Windows.Forms.Button btn_x;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Panel pnl_input;
        private MetroFramework.Controls.MetroButton btn_ingresar;
        private MetroFramework.Controls.MetroButton btn_registrarse;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

