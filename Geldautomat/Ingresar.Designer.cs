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
            this.pnl_input_ingresar = new System.Windows.Forms.Panel();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_retirar = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnl_opciones
            // 
            this.pnl_opciones.Controls.Add(this.btn_retirar);
            this.pnl_opciones.Controls.Add(this.btn_consultar);
            this.pnl_opciones.Controls.Add(this.btn_ingresar);
            this.pnl_opciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_opciones.Location = new System.Drawing.Point(3, 3);
            this.pnl_opciones.Name = "pnl_opciones";
            this.pnl_opciones.Size = new System.Drawing.Size(180, 444);
            this.pnl_opciones.TabIndex = 0;
            // 
            // pnl_input_ingresar
            // 
            this.pnl_input_ingresar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_input_ingresar.Location = new System.Drawing.Point(189, 3);
            this.pnl_input_ingresar.Name = "pnl_input_ingresar";
            this.pnl_input_ingresar.Size = new System.Drawing.Size(608, 444);
            this.pnl_input_ingresar.TabIndex = 1;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(45, 129);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(75, 23);
            this.btn_ingresar.TabIndex = 0;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(45, 177);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_consultar.TabIndex = 1;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_retirar
            // 
            this.btn_retirar.Location = new System.Drawing.Point(45, 217);
            this.btn_retirar.Name = "btn_retirar";
            this.btn_retirar.Size = new System.Drawing.Size(75, 23);
            this.btn_retirar.TabIndex = 2;
            this.btn_retirar.Text = "Retirar";
            this.btn_retirar.UseVisualStyleBackColor = true;
            this.btn_retirar.Click += new System.EventHandler(this.btn_retirar_Click);
            // 
            // Ingresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ingresar";
            this.Text = "Ingresar";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnl_opciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnl_opciones;
        private System.Windows.Forms.Button btn_retirar;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Panel pnl_input_ingresar;
    }
}