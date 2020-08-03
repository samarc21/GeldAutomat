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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_nombre = new MetroFramework.Controls.MetroTextBox();
            this.txt_pin = new MetroFramework.Controls.MetroTextBox();
            this.txt_montoinicial = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_confPin = new MetroFramework.Controls.MetroTextBox();
            this.btn_comReg = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(152, 120);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 20);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Nombre";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(152, 185);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 20);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Monto";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(162, 237);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(28, 20);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "Pin";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(241, 120);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(110, 23);
            this.txt_nombre.TabIndex = 22;
            // 
            // txt_pin
            // 
            this.txt_pin.Location = new System.Drawing.Point(241, 234);
            this.txt_pin.Name = "txt_pin";
            this.txt_pin.Size = new System.Drawing.Size(110, 23);
            this.txt_pin.TabIndex = 23;
            // 
            // txt_montoinicial
            // 
            this.txt_montoinicial.Location = new System.Drawing.Point(241, 173);
            this.txt_montoinicial.Name = "txt_montoinicial";
            this.txt_montoinicial.Size = new System.Drawing.Size(110, 23);
            this.txt_montoinicial.TabIndex = 24;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(120, 295);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(93, 20);
            this.metroLabel4.TabIndex = 25;
            this.metroLabel4.Text = "Confirmar Pin";
            // 
            // txt_confPin
            // 
            this.txt_confPin.Location = new System.Drawing.Point(241, 295);
            this.txt_confPin.Name = "txt_confPin";
            this.txt_confPin.Size = new System.Drawing.Size(110, 23);
            this.txt_confPin.TabIndex = 26;
            // 
            // btn_comReg
            // 
            this.btn_comReg.Location = new System.Drawing.Point(197, 353);
            this.btn_comReg.Name = "btn_comReg";
            this.btn_comReg.Size = new System.Drawing.Size(169, 23);
            this.btn_comReg.TabIndex = 27;
            this.btn_comReg.Text = "Completar Registro";
            this.btn_comReg.Click += new System.EventHandler(this.btn_comReg_Click);
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_comReg);
            this.Controls.Add(this.txt_confPin);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txt_montoinicial);
            this.Controls.Add(this.txt_pin);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registrar";
            this.Text = "Registrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_nombre;
        private MetroFramework.Controls.MetroTextBox txt_pin;
        private MetroFramework.Controls.MetroTextBox txt_montoinicial;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_confPin;
        private MetroFramework.Controls.MetroButton btn_comReg;
    }
}