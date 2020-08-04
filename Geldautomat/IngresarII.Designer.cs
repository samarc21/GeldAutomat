namespace Geldautomat
{
    partial class IngresarII
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txt_loginpin = new MetroFramework.Controls.MetroTextBox();
            this.txt_user = new MetroFramework.Controls.MetroTextBox();
            this.Pin = new MetroFramework.Controls.MetroLabel();
            this.Usuario = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(43, 216);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(140, 19);
            this.metroButton1.TabIndex = 14;
            this.metroButton1.Text = "Ingresar";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txt_loginpin
            // 
            this.txt_loginpin.Location = new System.Drawing.Point(102, 159);
            this.txt_loginpin.Margin = new System.Windows.Forms.Padding(2);
            this.txt_loginpin.Name = "txt_loginpin";
            this.txt_loginpin.Size = new System.Drawing.Size(73, 19);
            this.txt_loginpin.TabIndex = 13;
            this.txt_loginpin.Click += new System.EventHandler(this.txt_loginpin_Click_1);
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(102, 130);
            this.txt_user.Margin = new System.Windows.Forms.Padding(2);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(73, 19);
            this.txt_user.TabIndex = 12;
            this.txt_user.Click += new System.EventHandler(this.txt_user_Click_1);
            // 
            // Pin
            // 
            this.Pin.AutoSize = true;
            this.Pin.Location = new System.Drawing.Point(54, 159);
            this.Pin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Pin.Name = "Pin";
            this.Pin.Size = new System.Drawing.Size(27, 19);
            this.Pin.TabIndex = 11;
            this.Pin.Text = "Pin";
            this.Pin.Click += new System.EventHandler(this.Pin_Click);
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(43, 130);
            this.Usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(53, 19);
            this.Usuario.TabIndex = 10;
            this.Usuario.Text = "Usuario";
            this.Usuario.Click += new System.EventHandler(this.Usuario_Click_1);
            // 
            // IngresarII
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txt_loginpin);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.Pin);
            this.Controls.Add(this.Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngresarII";
            this.Text = "IngresarII";
            this.Load += new System.EventHandler(this.IngresarII_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txt_loginpin;
        private MetroFramework.Controls.MetroTextBox txt_user;
        private MetroFramework.Controls.MetroLabel Pin;
        private MetroFramework.Controls.MetroLabel Usuario;
    }
}