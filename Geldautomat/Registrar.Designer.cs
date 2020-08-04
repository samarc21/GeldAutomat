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
            this.User = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_comReg = new System.Windows.Forms.Button();
            this.lbl_confpin = new System.Windows.Forms.Label();
            this.lbl_pin = new System.Windows.Forms.Label();
            this.lbl_monto = new System.Windows.Forms.Label();
            this.txt_pin = new System.Windows.Forms.TextBox();
            this.txt_confPin = new System.Windows.Forms.TextBox();
            this.txt_montoinicial = new System.Windows.Forms.TextBox();
            this.rbtn_dol = new System.Windows.Forms.RadioButton();
            this.rbtn_cordoba = new System.Windows.Forms.RadioButton();
            this.pnl_registro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_registro
            // 
            this.pnl_registro.Controls.Add(this.rbtn_cordoba);
            this.pnl_registro.Controls.Add(this.rbtn_dol);
            this.pnl_registro.Controls.Add(this.txt_montoinicial);
            this.pnl_registro.Controls.Add(this.txt_confPin);
            this.pnl_registro.Controls.Add(this.txt_pin);
            this.pnl_registro.Controls.Add(this.lbl_monto);
            this.pnl_registro.Controls.Add(this.lbl_pin);
            this.pnl_registro.Controls.Add(this.lbl_confpin);
            this.pnl_registro.Controls.Add(this.btn_comReg);
            this.pnl_registro.Controls.Add(this.txt_nombre);
            this.pnl_registro.Controls.Add(this.User);
            this.pnl_registro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_registro.Location = new System.Drawing.Point(0, 0);
            this.pnl_registro.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_registro.Name = "pnl_registro";
            this.pnl_registro.Size = new System.Drawing.Size(1067, 554);
            this.pnl_registro.TabIndex = 0;
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(160, 101);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(57, 17);
            this.User.TabIndex = 41;
            this.User.Text = "Usuario";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(245, 96);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 22);
            this.txt_nombre.TabIndex = 42;
            // 
            // btn_comReg
            // 
            this.btn_comReg.Location = new System.Drawing.Point(154, 337);
            this.btn_comReg.Name = "btn_comReg";
            this.btn_comReg.Size = new System.Drawing.Size(240, 30);
            this.btn_comReg.TabIndex = 43;
            this.btn_comReg.Text = "Completar Registro";
            this.btn_comReg.UseVisualStyleBackColor = true;
            this.btn_comReg.Click += new System.EventHandler(this.btn_comReg_Click);
            // 
            // lbl_confpin
            // 
            this.lbl_confpin.AutoSize = true;
            this.lbl_confpin.Location = new System.Drawing.Point(137, 252);
            this.lbl_confpin.Name = "lbl_confpin";
            this.lbl_confpin.Size = new System.Drawing.Size(93, 17);
            this.lbl_confpin.TabIndex = 44;
            this.lbl_confpin.Text = "Confirmar Pin";
            // 
            // lbl_pin
            // 
            this.lbl_pin.AutoSize = true;
            this.lbl_pin.Location = new System.Drawing.Point(160, 211);
            this.lbl_pin.Name = "lbl_pin";
            this.lbl_pin.Size = new System.Drawing.Size(28, 17);
            this.lbl_pin.TabIndex = 45;
            this.lbl_pin.Text = "Pin";
            // 
            // lbl_monto
            // 
            this.lbl_monto.AutoSize = true;
            this.lbl_monto.Location = new System.Drawing.Point(160, 150);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(47, 17);
            this.lbl_monto.TabIndex = 46;
            this.lbl_monto.Text = "Monto";
            // 
            // txt_pin
            // 
            this.txt_pin.Location = new System.Drawing.Point(245, 206);
            this.txt_pin.Name = "txt_pin";
            this.txt_pin.Size = new System.Drawing.Size(100, 22);
            this.txt_pin.TabIndex = 47;
            // 
            // txt_confPin
            // 
            this.txt_confPin.Location = new System.Drawing.Point(245, 252);
            this.txt_confPin.Name = "txt_confPin";
            this.txt_confPin.Size = new System.Drawing.Size(100, 22);
            this.txt_confPin.TabIndex = 48;
            // 
            // txt_montoinicial
            // 
            this.txt_montoinicial.Location = new System.Drawing.Point(245, 145);
            this.txt_montoinicial.Name = "txt_montoinicial";
            this.txt_montoinicial.Size = new System.Drawing.Size(100, 22);
            this.txt_montoinicial.TabIndex = 49;
            // 
            // rbtn_dol
            // 
            this.rbtn_dol.AutoSize = true;
            this.rbtn_dol.Location = new System.Drawing.Point(380, 145);
            this.rbtn_dol.Name = "rbtn_dol";
            this.rbtn_dol.Size = new System.Drawing.Size(37, 21);
            this.rbtn_dol.TabIndex = 50;
            this.rbtn_dol.TabStop = true;
            this.rbtn_dol.Text = "$";
            this.rbtn_dol.UseVisualStyleBackColor = true;
            // 
            // rbtn_cordoba
            // 
            this.rbtn_cordoba.AutoSize = true;
            this.rbtn_cordoba.Location = new System.Drawing.Point(433, 146);
            this.rbtn_cordoba.Name = "rbtn_cordoba";
            this.rbtn_cordoba.Size = new System.Drawing.Size(46, 21);
            this.rbtn_cordoba.TabIndex = 51;
            this.rbtn_cordoba.TabStop = true;
            this.rbtn_cordoba.Text = "C$";
            this.rbtn_cordoba.UseVisualStyleBackColor = true;
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pnl_registro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registrar";
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.Registrar_Load);
            this.pnl_registro.ResumeLayout(false);
            this.pnl_registro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_registro;
        private System.Windows.Forms.TextBox txt_montoinicial;
        private System.Windows.Forms.TextBox txt_confPin;
        private System.Windows.Forms.TextBox txt_pin;
        private System.Windows.Forms.Label lbl_monto;
        private System.Windows.Forms.Label lbl_pin;
        private System.Windows.Forms.Label lbl_confpin;
        private System.Windows.Forms.Button btn_comReg;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.RadioButton rbtn_cordoba;
        private System.Windows.Forms.RadioButton rbtn_dol;
    }
}