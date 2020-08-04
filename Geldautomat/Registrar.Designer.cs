namespace Geldautomat
{
    partial class Registrar
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
            this.pnl_registro = new System.Windows.Forms.Panel();
            this.rbtn_cordoba = new MetroFramework.Controls.MetroRadioButton();
            this.rbtn_dol = new MetroFramework.Controls.MetroRadioButton();
            this.btn_comReg = new MetroFramework.Controls.MetroButton();
            this.txt_confPin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_montoinicial = new MetroFramework.Controls.MetroTextBox();
            this.txt_pin = new MetroFramework.Controls.MetroTextBox();
            this.txt_nombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pnl_registro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_registro
            // 
            this.pnl_registro.Controls.Add(this.rbtn_cordoba);
            this.pnl_registro.Controls.Add(this.rbtn_dol);
            this.pnl_registro.Controls.Add(this.btn_comReg);
            this.pnl_registro.Controls.Add(this.txt_confPin);
            this.pnl_registro.Controls.Add(this.metroLabel4);
            this.pnl_registro.Controls.Add(this.txt_montoinicial);
            this.pnl_registro.Controls.Add(this.txt_pin);
            this.pnl_registro.Controls.Add(this.txt_nombre);
            this.pnl_registro.Controls.Add(this.metroLabel3);
            this.pnl_registro.Controls.Add(this.metroLabel2);
            this.pnl_registro.Controls.Add(this.metroLabel1);
            this.pnl_registro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_registro.Location = new System.Drawing.Point(0, 0);
            this.pnl_registro.Name = "pnl_registro";
            this.pnl_registro.Size = new System.Drawing.Size(800, 450);
            this.pnl_registro.TabIndex = 0;
            // 
            // rbtn_cordoba
            // 
            this.rbtn_cordoba.AutoSize = true;
            this.rbtn_cordoba.Location = new System.Drawing.Point(317, 122);
            this.rbtn_cordoba.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_cordoba.Name = "rbtn_cordoba";
            this.rbtn_cordoba.Size = new System.Drawing.Size(37, 15);
            this.rbtn_cordoba.TabIndex = 40;
            this.rbtn_cordoba.TabStop = true;
            this.rbtn_cordoba.Text = "C$";
            this.rbtn_cordoba.UseVisualStyleBackColor = true;
            // 
            // rbtn_dol
            // 
            this.rbtn_dol.AutoSize = true;
            this.rbtn_dol.Location = new System.Drawing.Point(281, 122);
            this.rbtn_dol.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_dol.Name = "rbtn_dol";
            this.rbtn_dol.Size = new System.Drawing.Size(29, 15);
            this.rbtn_dol.TabIndex = 39;
            this.rbtn_dol.TabStop = true;
            this.rbtn_dol.Text = "$";
            this.rbtn_dol.UseVisualStyleBackColor = true;
            // 
            // btn_comReg
            // 
            this.btn_comReg.Location = new System.Drawing.Point(151, 266);
            this.btn_comReg.Margin = new System.Windows.Forms.Padding(2);
            this.btn_comReg.Name = "btn_comReg";
            this.btn_comReg.Size = new System.Drawing.Size(127, 19);
            this.btn_comReg.TabIndex = 38;
            this.btn_comReg.Text = "Completar Registro";
            this.btn_comReg.Click += new System.EventHandler(this.btn_comReg_Click_1);
            // 
            // txt_confPin
            // 
            this.txt_confPin.Location = new System.Drawing.Point(184, 202);
            this.txt_confPin.Margin = new System.Windows.Forms.Padding(2);
            this.txt_confPin.Name = "txt_confPin";
            this.txt_confPin.Size = new System.Drawing.Size(82, 19);
            this.txt_confPin.TabIndex = 37;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(85, 205);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(91, 19);
            this.metroLabel4.TabIndex = 36;
            this.metroLabel4.Text = "Confirmar Pin";
            // 
            // txt_montoinicial
            // 
            this.txt_montoinicial.Location = new System.Drawing.Point(184, 120);
            this.txt_montoinicial.Margin = new System.Windows.Forms.Padding(2);
            this.txt_montoinicial.Name = "txt_montoinicial";
            this.txt_montoinicial.Size = new System.Drawing.Size(82, 19);
            this.txt_montoinicial.TabIndex = 35;
            this.txt_montoinicial.Click += new System.EventHandler(this.txt_montoinicial_Click);
            // 
            // txt_pin
            // 
            this.txt_pin.Location = new System.Drawing.Point(184, 154);
            this.txt_pin.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pin.Name = "txt_pin";
            this.txt_pin.Size = new System.Drawing.Size(82, 19);
            this.txt_pin.TabIndex = 34;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(184, 76);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(82, 19);
            this.txt_nombre.TabIndex = 33;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(93, 169);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(27, 19);
            this.metroLabel3.TabIndex = 32;
            this.metroLabel3.Text = "Pin";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(93, 122);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 31;
            this.metroLabel2.Text = "Monto";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(93, 76);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Nombre";
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_registro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registrar";
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.Registrar_Load);
            this.pnl_registro.ResumeLayout(false);
            this.pnl_registro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_registro;
        private MetroFramework.Controls.MetroRadioButton rbtn_cordoba;
        private MetroFramework.Controls.MetroRadioButton rbtn_dol;
        private MetroFramework.Controls.MetroButton btn_comReg;
        private MetroFramework.Controls.MetroTextBox txt_confPin;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_montoinicial;
        private MetroFramework.Controls.MetroTextBox txt_pin;
        private MetroFramework.Controls.MetroTextBox txt_nombre;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}