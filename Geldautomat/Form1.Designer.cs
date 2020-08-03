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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_bienvenido = new System.Windows.Forms.Panel();
            this.btn_x = new System.Windows.Forms.Button();
            this.lbl_bienvenido = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_registrarse = new MetroFramework.Controls.MetroButton();
            this.btn_ingresar = new MetroFramework.Controls.MetroButton();
            this.pnl_input = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnl_bienvenido.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnl_bienvenido, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 87);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnl_bienvenido
            // 
            this.pnl_bienvenido.Controls.Add(this.btn_x);
            this.pnl_bienvenido.Controls.Add(this.lbl_bienvenido);
            this.pnl_bienvenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_bienvenido.Location = new System.Drawing.Point(4, 4);
            this.pnl_bienvenido.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_bienvenido.Name = "pnl_bienvenido";
            this.pnl_bienvenido.Size = new System.Drawing.Size(1059, 79);
            this.pnl_bienvenido.TabIndex = 0;
            // 
            // btn_x
            // 
            this.btn_x.Location = new System.Drawing.Point(947, 44);
            this.btn_x.Margin = new System.Windows.Forms.Padding(4);
            this.btn_x.Name = "btn_x";
            this.btn_x.Size = new System.Drawing.Size(100, 28);
            this.btn_x.TabIndex = 1;
            this.btn_x.Text = "X";
            this.btn_x.UseVisualStyleBackColor = true;
            this.btn_x.Click += new System.EventHandler(this.btn_x_Click);
            // 
            // lbl_bienvenido
            // 
            this.lbl_bienvenido.AutoSize = true;
            this.lbl_bienvenido.Location = new System.Drawing.Point(453, 57);
            this.lbl_bienvenido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bienvenido.Name = "lbl_bienvenido";
            this.lbl_bienvenido.Size = new System.Drawing.Size(70, 17);
            this.lbl_bienvenido.TabIndex = 0;
            this.lbl_bienvenido.Text = "Bievenido";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.24555F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.75445F));
            this.tableLayoutPanel2.Controls.Add(this.pnl_menu, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnl_input, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 87);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1067, 467);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pnl_menu
            // 
            this.pnl_menu.Controls.Add(this.btn_registrarse);
            this.pnl_menu.Controls.Add(this.btn_ingresar);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_menu.Location = new System.Drawing.Point(4, 4);
            this.pnl_menu.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(144, 459);
            this.pnl_menu.TabIndex = 0;
            // 
            // btn_registrarse
            // 
            this.btn_registrarse.Location = new System.Drawing.Point(45, 207);
            this.btn_registrarse.Name = "btn_registrarse";
            this.btn_registrarse.Size = new System.Drawing.Size(75, 23);
            this.btn_registrarse.TabIndex = 3;
            this.btn_registrarse.Text = "Registrar";
            this.btn_registrarse.Click += new System.EventHandler(this.btn_registrarse_Click_1);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(45, 137);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(75, 23);
            this.btn_ingresar.TabIndex = 2;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click_1);
            // 
            // pnl_input
            // 
            this.pnl_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_input.Location = new System.Drawing.Point(156, 4);
            this.pnl_input.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_input.Name = "pnl_input";
            this.pnl_input.Size = new System.Drawing.Size(907, 459);
            this.pnl_input.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnl_bienvenido.ResumeLayout(false);
            this.pnl_bienvenido.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnl_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnl_bienvenido;
        private System.Windows.Forms.Button btn_x;
        private System.Windows.Forms.Label lbl_bienvenido;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Panel pnl_input;
        private MetroFramework.Controls.MetroButton btn_ingresar;
        private MetroFramework.Controls.MetroButton btn_registrarse;
    }
}

